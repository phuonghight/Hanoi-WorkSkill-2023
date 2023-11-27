package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button login = findViewById(R.id.btn_login);
        login.setOnClickListener(v -> {
            Connection connection = SQLConnector.connect();
            if (connection != null) {
                String un = ((TextView) findViewById(R.id.edt_username)).getText().toString();
                String pass = ((TextView) findViewById(R.id.edt_password)).getText().toString();
                try {
                    Statement stm = connection.createStatement();
                    ResultSet rs = stm.executeQuery("select * from Users");
                    while (rs.next()) {
                        if(un.equals(rs.getString("Username")) && pass.equals(rs.getString("Password"))) {
                            Toast.makeText(this, "Login Successful", Toast.LENGTH_SHORT).show();
                            startActivity(new Intent(this, Listing.class));
                        }
                    }
                } catch (SQLException e) {
                    throw new RuntimeException(e);
                }
            }
        });
    }
}