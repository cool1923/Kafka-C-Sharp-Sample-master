# Kafka Demo with Landoop
Here's a simple demo of a producer and consumer for Kafka.

[![Build status](https://ci.appveyor.com/api/projects/status/57kp8qdv74lk0006?svg=true)](https://ci.appveyor.com/project/mrjamiebowman/kafka-c-sharp-sample)

TODO: partitions for consumer  
TODO: keys for offsets  

## Blog Post
[mrjamiebowman.com: Getting Started with Landoop Kafka on Docker Locally](https://www.mrjamiebowman.com/software-development/getting-started-with-landoop-kafka-on-docker-locally/)

## Staring Kafka Locally with Docker
`docker pull landoop/fast-data-dev`
	
`docker run -e ADV_HOST=127.0.0.1 -e LICENSE_URL="[CHECK_YOUR_EMAIL_FOR_PERSONAL_ID]" -p 3030:3030 -p 9092:9092 -p 2181:2181 -p 8081:8081 --name=landoopkafka landoop/kafka-lenses-dev`

`docker logs -f landoopkafka`

Once it's running you can access the dashboard here... [Landoop's Kafka UI](http://127.0.0.1:3030/)
