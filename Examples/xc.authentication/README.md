# XComponent Authentication

This project is a simple `authentication` microservice developped with [XComponent](http://www.xcomponent.com).

## Overview

XComponent is a platform to create, monitor and share microservices.
If you want to have more details about microservices, you should read [Martin Fowler's article.](http://martinfowler.com/articles/microservices.html)

In the `authentication` sample we're actually going to run two different pieces of software concurrently:
* **`[Authentication microservice]`** - A microservice that receives *login* requests 
* **`[Console Application]`** - A simple application sending *login* requests to our microservice

## Build the project

Execute the following script:
```
PS > ./build.ps1
```

## Run the example

Execute the following script :
```
PS > ./run.cmd
```

> Note: RabbitMQ has to be running (default configuration)

### Open XComponent project

Execute the following script at the root:
```
PS > ./xcstudio.cmd
```

## "Authentication" project details

More informations: [Click here](documentation/README.md)

## Questions?

If you have any questions about this sample, please [create a Github issue for us](https://github.com/xcomponent/xcomponent/issues)!
