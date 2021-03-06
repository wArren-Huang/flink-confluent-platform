CREATE TABLE tag_values (
  the_kafka_key STRING,
  tagName STRING,
  tagValue DOUBLE
) WITH (
  'connector' = 'kafka',
  'topic' = 'tag-values',
  'properties.bootstrap.servers' = 'broker:29092',

  'key.format' = 'raw',
  'key.fields' = 'the_kafka_key',

  'value.format' = 'avro-confluent',
  'value.avro-confluent.schema-registry.url' = 'http://schema-registry:8081',
  'value.fields-include' = 'EXCEPT_KEY'
);