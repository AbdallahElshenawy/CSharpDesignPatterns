# 🦸‍♂️ Chain of Responsibility Pattern — Superhero Example

## 📜 Definition
The **Chain of Responsibility** pattern is a behavioral design pattern that allows you to pass a request along a chain of handlers. Each handler decides whether to process the request or pass it to the next handler in the chain.

This helps you decouple the sender of the request from its receivers.

---

## 🎯 Intent
- Avoid coupling the sender of a request to its receiver.
- Give multiple objects the opportunity to handle a request.
- Process requests in a chain until one object handles it.

---
## 🛠 Implementation Steps
1. **Handler Interface** — Declares a method for handling requests and an optional link to the next handler.
2. **Concrete Handlers** — Implement the request handling and decide whether to pass the request to the next handler.
3. **Client** — Creates the chain and sends the request.
---
## 🧠 Use Cases of the Chain of Responsibility Pattern 
```
| Use Case                     | Description                                                                  
| 🦸 Superhero Squad           | Each hero tries to handle a threat; if they can't, they pass it to the next hero.
| 📞 Customer Support          | Calls escalate from front-line support to managers to specialists.            
| 🏦 Banking Transaction Check | Fraud detection steps pass through multiple checks until approved or rejected. 
| 🔐 Security Pipelines        | Multiple authentication and validation layers process a login request.         
```
---


## 🚀  Real-World Example: Super hero Emergency Call

Imagine a world where superheroes take turns deciding if they should handle a problem.  
Each superhero has their **own unique superpower** and will only act if the situation matches their expertise.

For example:
1. **Batman** handles street-level crimes (like muggings and robberies).
2. **Aquaman** handles flood threats.
3. **Superman** handles magical threats.

If Batman can't handle the problem, he passes it to Aquaman… and so on until the right hero steps in.

---

## ✅ Key Features

- ✅ Decouples the request sender from the handlers. 
- ✅ Flexible chain setup — reorder or change heroes without touching the sender code.
- ✅ Supports multiple processing paths.
- ✅ Makes it easy to extend responsibilities without breaking existing code.  
---

## 🎯 Chain of Responsibility Pattern Pros & Cons

```
 Pros                                                     | Cons                                                           
 Decouples sender from receiver                           | Requests might go unhandled if no handler processes them       
 Easy to add/remove/reorder handlers                      | Can be harder to debug in long chains                         
 Supports dynamic runtime configuration                   | Performance overhead if chain is very long                    
 Promotes single responsibility per handler                                                                               
