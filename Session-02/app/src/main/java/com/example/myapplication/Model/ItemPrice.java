package com.example.myapplication.Model;

import java.math.BigDecimal;

public class ItemPrice {
    private long id;
    private String date;
    private BigDecimal price;
    private String rule;

    public ItemPrice() {
    }

    public ItemPrice(long id, String date, BigDecimal price, String rule) {
        this.id = id;
        this.date = date;
        this.price = price;
        this.rule = rule;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public BigDecimal getPrice() {
        return price;
    }

    public void setPrice(BigDecimal price) {
        this.price = price;
    }

    public String getRule() {
        return rule;
    }

    public void setRule(String rule) {
        this.rule = rule;
    }
}
