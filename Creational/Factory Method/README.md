# 🏭 Factory Method Pattern in C#

## 📌 What is the Factory Method Pattern?

The **Factory Method** is a **creational design pattern** that provides an **interface for creating objects** in a superclass, while allowing **subclasses to alter the type of objects** that will be created.

Instead of using `new` directly, the creation logic is **delegated to subclasses**, enabling a more **flexible, extensible, and decoupled design**.

### ✅ You should use the Factory Method when:
- You want to **delegate the responsibility of instantiation** to child classes.
- You want to **decouple** the client from specific concrete classes.
- You expect your app to **evolve with multiple object types** over time.

---

## 🧠 Use Cases of the Factory Method Pattern



```
| Use Case                       | Description                                                                

| 🧾 Report Generation          | Different types of reports (PDF, Excel, Word) can be generated dynamically
| 💳 Payment Gateways           | Supports multiple payment providers (PayPal, Stripe, Vodafone Cash, etc.)
| 🔌 Plugin Systems             | Load plugins without tightly coupling to their concrete implementations
| 📃 Document Editors           | Create different document types (Resume, Report, Invoice)
| 🎮 Game Engines               | Create various game elements (enemies, weapons, levels) dynamically


```
## 🚀 Real-World Example: Document Page Builder

In this example, we simulate a system that generates documents (like Resume or Report) that consist of different types of pages. Each document type defines its own content through the factory method.
### Components:
- **Page (Product):** The base type for all pages in the document.
- **SkillsPage, EducationPage ,etc.(Concrete Products):** real pages used in specific document types.
- **Document (Creator):**  Abstract class that declares the factory method CreatePages().
- **Resume / Report (Concrete Creators):** Subclasses that override the factory method and define their specific page content.
- **Main Program (Client):** Creates the documents and calls the factory method.
---

## ✅ Key Features

- ✅ Promotes Open/Closed Principle: add new document types without changing base class

- ✅ Hides object creation logic from the client

- ✅ Allows subclasses to specify which class to instantiate

- ✅ Encourages code reusability and flexibility

- ✅ Suitable for applications where object creation logic changes frequently

---

# 🟢 Factory Method Pattern Pros & Cons


```
|            Pros                                                                     |                               Cons
|-------------------------------------------------------------------------------------|----------------------------------------------------------------------
| Eliminates tight coupling between creator and concrete products                     | Code can become complex with too many subclasses
| Makes code easier to test by decoupling object creation                             | Requires creating multiple new classes for each product variation
| Helps adhere to SOLID principles (especially Open/Closed and Single Responsibility) | Initial setup may feel heavy for simple scenarios
