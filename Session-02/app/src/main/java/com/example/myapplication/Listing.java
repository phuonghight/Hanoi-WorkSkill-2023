package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.widget.Toast;

import com.example.myapplication.Model.Item;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class Listing extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_listing);
        Connection con = SQLConnector.connect();
        if(con != null) {
            List<Item> items = new ArrayList<>();
            try {
                Statement stm = con.createStatement();
                ResultSet rs = stm.executeQuery("select i.ID, i.Title, max(ip.Date) as Date from Items i join ItemPrices ip on ip.ItemID = i.ID group by i.Title, i.ID");
                while (rs.next()) {
                    Item item = new Item(rs.getLong("ID"), rs.getString("Title"), rs.getDate("Date").toString());
                    items.add(item);
                }
                ListingAdapter adapter = new ListingAdapter(items);
                RecyclerView rcv = findViewById(R.id.rcv_listing);
                rcv.setLayoutManager(new LinearLayoutManager(this));
                rcv.setAdapter(adapter);
            } catch (SQLException e) {
                throw new RuntimeException(e);
            }
        }
    }
}