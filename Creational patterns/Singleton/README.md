# 👤 Singleton Pattern in C#

## 📌 What is the Singleton Pattern?

The **Singleton** design pattern ensures that a class has **only one instance** and provides a **global point of access** to it.

It is commonly used when:
- Exactly one object is needed to coordinate actions across the system.
- You want to avoid redundant objects (e.g., logging, config, caching, DB access).

---

# Singleton Pattern Use Cases


```
| Use Case                    |                 Description 

| 🧾 Logger                   | Centralized logger writing to file, console, or cloud log 

| ⚙️ Configuration Manager    | Loads settings from a config file or database, shared across app 

| 🗃️ Database Connection Pool | Manages reusable DB connections to reduce overhead 

| 🧠 Caching System           | Shared in-memory or distributed cache service like Redis or MemoryCache 

| 🛡️ Authentication Context   | Stores the current user session or token globally during the app lifecycle 
```

## 🚀 Real-World Example: Load Balancer

In this example, we simulate a **load balancer** that distributes requests across multiple servers.  
The goal is to make sure all components of the app refer to the **same LoadBalancer instance**, simulateing real-world infrastructure component.

## ✅ Key Features

- ✅ Ensures **only one LoadBalancer** exists
- ✅ Uses **eager initialization** with `static readonly`
- ✅ Thread-safe by design (.NET handles static initialization)
- ✅ Randomly assigns each request to a server from a predefined list

# Singleton Pattern Pros & Cons


```
|            Pros                                                                  |                               Cons

|  You can be sure that a class has only a single instance.                        | Violates the Single Responsibility Principle. Singleton might take on too many responsibilities
|  You gain a global access point to that instance.                                | Singleton can complicate unit testing due to their persistent state, often requiring mocks or resets.
| The singleton object is initialized only when it’s requested for the first time. | The pattern requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
