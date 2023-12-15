package com.example.myapplication.controller;

import com.gaion.kisadashboardjava.service.AiDroneService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/")
public class ProjectController {

    @Autowired
    private ProjectService proejctService;

    @GetMapping
    public String hello() {
        return "Hello, World!";
    }

    @GetMapping("/api/distinct")
    public List<String> realtime() {
        return projectService.getDistinctFieldNames();
    }
}