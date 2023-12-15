package com.example.myapplication.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.mongodb.core.MongoTemplate;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.ArrayList;

@Service
public class ProejctService {

    private final MongoTemplate mongoTemplate;

    @Autowired
    public ProejctService(MongoTemplate mongoTemplate) {
        this.mongoTemplate = mongoTemplate;
    }

    public List<String> getDistinctFieldNames() {
        return mongoTemplate.getCollection("collection_name")
                .distinct("field_name", String.class)
                .into(new ArrayList<>());
    }
}

/*
* Spring Data MongoDB 에서는 MongoDB에 연결하려면 MongoTemplate를 사용해야 한다.
* 이를 위해 Spirng Boot 프로젝트의 'application.properites' 또는 'application.yml' 파일에
* MongoDB 관련 설정을 추가해야 한다.
* 그리고 ProejctService 에서 MongoTemplate를 @Autowired 어노테이션을 사용하여 주입 받는다.
*/