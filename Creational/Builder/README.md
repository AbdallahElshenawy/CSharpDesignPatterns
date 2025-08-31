# 🚗 Builder Pattern in C#

## 📌 What is the Builder Pattern?

The **Builder** design pattern is a **creational pattern** that lets you construct complex objects step by step.  
It separates the **construction process** (the "how") from the **representation** (the "what").  

This allows the same construction process to create **different representations** of objects.

---

## ✅ You Should Use the Builder Pattern When:

- You need to **create complex objects** with multiple parts.  
- You want to **reuse the construction process** for different object types.  
- You want to avoid **telescoping constructors** (too many parameters).  
- You want to build objects step by step with flexibility.  

---

## 🧠 Use Cases of the Factory Method Pattern



```
Use Case	                   |                  Description

🏗️ Vehicle Manufacturing       | Cars, bikes, and scooters share parts but differ in construction.
🍔 Food Ordering Systems	   | Build meals step by step (burger, fries, drink, dessert).
🖥️ Computer Assembly	       | Build custom PCs by choosing CPU, GPU, RAM, storage, etc.
🏨 Travel Booking Systems	   | Construct a vacation package (flight + hotel + activities).
🎮 Game Character Creation	   | Step-by-step building of characters (race, skills, weapons, armor).

```
## 🚀 Real-World Example: building vehicles

In this example, we simulate a system that builds **different types of vehicles** (Car, Scooter, Motorcycle).  

Each vehicle is built **step by step**: adding a frame, engine, wheels, and doors.  
The **Shop (Director)** controls the building process, while each **Concrete Builder** defines how those parts are created.

### Components:
- **Vehicle (Product):** The object being built (Car, Scooter, Motorcycle).  
- **VehicleBuilder (Builder):** Abstract class that defines the building steps.  
- **CarBuilder, ScooterBuilder, MotorCycleBuilder (Concrete Builders):** Implement the steps for each specific vehicle.  
- **Shop (Director):** Uses the builders to construct vehicles in a specific sequence.  
- **MainApp (Client):** Creates builders and asks the director to build the vehicles.  

---

## ✅ Key Features

- ✅ Builds complex objects **step by step**.  
- ✅ Separates **construction logic** from the final product.  
- ✅ Supports multiple representations of the same product.  
- ✅ Improves flexibility and reusability.  
- ✅ Makes code cleaner by avoiding huge constructors.  
---

# Builder Pattern Pros & Cons


```
|                Pros                                      |                            Cons  
                                                              
| Builds complex objects step by step                      | More boilerplate code compared to simple constructors               
| Supports different representations of the same product   | Might be overkill for simple objects                               
| Encapsulates construction logic                          | Requires Director if construction steps must follow strict order    
| Improves code readability and reusability                | Adds extra layers of abstraction                                    

