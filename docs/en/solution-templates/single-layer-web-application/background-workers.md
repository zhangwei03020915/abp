# Single Layer Solution: Background Workers

```json
//[doc-nav]
{
  "Previous": {
    "Name": "Background Jobs",
    "Path": "solution-templates/single-layer-web-application/background-jobs"
  },
  "Next": {
    "Name": "Multi-Tenancy",
    "Path": "solution-templates/single-layer-web-application/multi-tenancy"
  }
}
```

Background workers are long-running processes that run in the background of your application. They are useful for tasks that are not time-sensitive, such as processing data, sending notifications, or monitoring system health. Background workers are typically started when the application starts and run continuously until the application stops. You can learn more about background workers in the [Background Workers](../../framework/infrastructure/background-workers/index.md) document.

> When scaling out your application in a distributed system, it's crucial to consider that the same background workers might run on multiple instances of the same service. This requires careful management of potential side effects. For example, if you're processing messages from a queue, you need to ensure that each message is processed only once. To prevent multiple instances from handling the same message, you can use [distributed locking](../../framework/infrastructure/distributed-locking.md).
