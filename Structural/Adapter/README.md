
# Adapter Design Pattern 🔌

## 📖 Overview
The **Adapter Pattern** is a structural design pattern that allows incompatible interfaces to work together.  
It acts as a **bridge** between two classes, converting the interface of a class into another interface that a client expects.  

This is especially useful when you want to reuse existing classes but their interfaces don’t match the one your system requires.

---

## ✅ You Should Use the Adapter Pattern When:

- You need to integrate **incompatible systems**.  
- You want to reuse existing classes that don’t have the required interface.  
- You need to connect **legacy code** with new systems.  
- You want to follow the **Open/Closed Principle** (extend functionality without modifying existing code).  

---

## 🧠 Use Cases of the Adapter Pattern







```
Use Case	                         |                  Description

🔌 Power Plug Converters             | Convert European plugs to fit US sockets (travel adapters).
💳 Payment Gateway Integration       | Adapt new payment APIs into existing systems.
📂 File Conversion Tools	          | Convert between JSON, XML, or CSV formats transparently.
🎮 Game Controllers                  | Use different controller types (Xbox, PlayStation) with the same game.
📡 Legacy System Integration	     | Connect old APIs or databases to modern applications.

```

---


---

## 🚀 Real-World Example: 🔌 Power Plug Adapter

Imagine traveling with your **European laptop charger** (two round pins) to the **USA**, where wall sockets accept only **flat pins**.  
You cannot plug your device directly, but a **travel adapter** solves this by converting the plug shape while still delivering power.  

This is exactly what the **Adapter Pattern** does — it adapts one interface to another without changing existing code.

### 🔑 Components:
- **Target (US Socket):** Defines the interface expected by the client.  
- **Adaptee (European Plug):** Existing class with an incompatible interface.  
- **Adapter (EuropeanToUSAdapter):** Bridges the gap between `EuropeanPlug` and `USSocket`.  
- **Client (Traveler/Device):** Uses the adapter to connect incompatible systems.  

---

## ✅ Key Features

- ✅ Connects incompatible interfaces without modifying them.  
- ✅ Encourages reusability of existing code.  
- ✅ Provides a **flexible and decoupled design**.  
- ✅ Helps integrate **legacy systems** with modern applications.  

---

# Adapter Pattern Pros & Cons




```
|                Pros                                       |                            Cons  
                                                              
|Allows reuse of existing classes                           | Can add extra complexity if overused
| Promotes loose coupling between systems                   | May reduce performance due to extra translation layer
| Bridges legacy and modern systems efficiently             | Too many adapters can make code harder to maintain
