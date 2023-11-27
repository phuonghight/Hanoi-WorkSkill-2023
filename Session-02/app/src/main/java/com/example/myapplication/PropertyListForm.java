package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.ItemTouchHelper;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.myapplication.Model.ItemPrice;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class PropertyListForm extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_property_list_form);

        Spinner spn_weekend = findViewById(R.id.spn_weekend);
        Spinner spn_holiday = findViewById(R.id.spn_holiday);
        Spinner spn_day = findViewById(R.id.spn_day);
        List<Spinner> spinners = new ArrayList<>();
        spinners.add(spn_weekend);
        spinners.add(spn_holiday);
        spinners.add(spn_day);

        long id = this.getIntent().getLongExtra("ID", 18);
        String title = this.getIntent().getStringExtra("Title");
        TextView tv_property = findViewById(R.id.tv_property);
        tv_property.setText(title);

        List<ItemPrice> itemPrices = new ArrayList<>();
        List<String> rules = new ArrayList<>();
        Connection con = SQLConnector.connect();
        if (con != null) {
            try {
                Statement stm = con.createStatement();
                ResultSet rs1 = stm.executeQuery("Select ip.ID, ip.Date, ip.Price, c.Name as Rules from ItemPrices ip join CancellationPolicies c" +
                        " on c.ID = ip.CancellationPolicyID where ip.ItemID = " + id);
                while (rs1.next()) {
                    ItemPrice ip = new ItemPrice(rs1.getLong("ID"), rs1.getString("Date"),
                            rs1.getBigDecimal("Price"), rs1.getString("Rules"));
                    itemPrices.add(ip);
                }

                rs1  = stm.executeQuery("Select * from CancellationPolicies");
                while (rs1.next()) {
                    rules.add(rs1.getString("Name"));
                }
            } catch (SQLException e) {
                throw new RuntimeException(e);
            }
        }

        PropertyListFormAdapter rcvAdapter = new PropertyListFormAdapter(itemPrices);
        RecyclerView rcv = findViewById(R.id.rcv_item_price);
        rcv.setLayoutManager(new LinearLayoutManager(this));
        rcv.setAdapter(rcvAdapter);

        new ItemTouchHelper(new ItemTouchHelper.SimpleCallback(0, ItemTouchHelper.LEFT) {
            @Override
            public boolean onMove(@NonNull RecyclerView recyclerView, @NonNull RecyclerView.ViewHolder viewHolder, @NonNull RecyclerView.ViewHolder target) {
                return false;
            }

            @Override
            public void onSwiped(@NonNull RecyclerView.ViewHolder viewHolder, int direction) {
                ItemPrice ipDeleted = itemPrices.get(viewHolder.getAdapterPosition());
                rcvAdapter.notifyItemRemoved(viewHolder.getAdapterPosition());
                try {
                    PreparedStatement pstm = con.prepareStatement("delete from ItemPrices where ID = ?");
                    pstm.setLong(1, ipDeleted.getId());
                    int result = pstm.executeUpdate();
                    if(result > 0)  {
                        Toast.makeText(PropertyListForm.this, "Delete Successful", Toast.LENGTH_SHORT).show();
                    } else Toast.makeText(PropertyListForm.this, "Delete Failed", Toast.LENGTH_SHORT).show();
                } catch (SQLException e) {
                    throw new RuntimeException(e);
                }
            }
        }).attachToRecyclerView(rcv);

        new ItemTouchHelper(new ItemTouchHelper.SimpleCallback(0, ItemTouchHelper.RIGHT) {
            @Override
            public boolean onMove(@NonNull RecyclerView recyclerView, @NonNull RecyclerView.ViewHolder viewHolder, @NonNull RecyclerView.ViewHolder target) {
                return false;
            }

            @Override
            public void onSwiped(@NonNull RecyclerView.ViewHolder viewHolder, int direction) {
                ItemPrice ipSelected = itemPrices.get(viewHolder.getAdapterPosition());
            }
        }).attachToRecyclerView(rcv);

        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_item, rules);
        arrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spn_weekend.setAdapter(arrayAdapter);
        spn_holiday.setAdapter(arrayAdapter);
        spn_day.setAdapter(arrayAdapter);

        spinners.forEach(spn -> {
            spn.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
                @Override
                public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

                }

                @Override
                public void onNothingSelected(AdapterView<?> parent) {

                }
            });
        });
    }

    public void back(View v) {
        finish();
    }
}