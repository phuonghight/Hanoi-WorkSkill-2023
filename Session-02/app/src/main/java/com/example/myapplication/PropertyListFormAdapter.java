package com.example.myapplication;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.myapplication.Model.ItemPrice;

import java.util.List;

public class PropertyListFormAdapter extends RecyclerView.Adapter<PropertyListFormAdapter.ViewHolder> {

    private List<ItemPrice> itemPrices;

    public PropertyListFormAdapter(List<ItemPrice> itemPrices) {
        this.itemPrices = itemPrices;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_price, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        ItemPrice ip  = itemPrices.get(position);
        holder.date.setText(ip.getDate());
        holder.price.setText(ip.getPrice().toString());
        holder.rule.setText(ip.getRule());
    }

    @Override
    public int getItemCount() {
        return this.itemPrices.size();
    }

    public static class ViewHolder extends RecyclerView.ViewHolder {
        TextView date;
        TextView price;
        TextView rule;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            date = itemView.findViewById(R.id.tv_item_price_date);
            price = itemView.findViewById(R.id.tv_item_price_price);
            rule = itemView.findViewById(R.id.tv_item_price_rule);
        }
    }
}
