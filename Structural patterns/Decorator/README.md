# 🧩 Decorator Pattern in C#

## 📌 What is the Decorator Pattern?

The **Decorator** design pattern allows you to **dynamically add new behavior or responsibilities** to objects without modifying their structure.

Instead of bloating your codebase with subclasses for every feature combination, the Decorator pattern lets you "wrap" objects in layers of functionality.

It is commonly used when:
- You want to **enhance or modify** an object’s behavior at runtime.
- You want to **combine features** flexibly without creating a rigid class hierarchy.
---

## 🧠 Use Cases of the Decorator Pattern

```
| Use Case                     |                              Description 

| 🍰 UI Components             | Dynamically add scrollbars, borders, or animations to windows or panels

| 🧾 Invoice Generation        | Apply tax, discounts, currency formatting to base invoice dynamically

| 🛒 E-commerce Checkout       | Add gift-wrapping, insurance, express delivery to a base order

| 🧪 Data Processing Pipelines | Add logging, filtering, or validation layers to raw data handlers 

```

## 🚀 Real-World Example: Hotel Room Booking 

In this example, we simulate a hotel reservation system where guests can start with a basic room and then dynamically add optional services such as:

- 🍽️ Breakfast  
- 🧘 Spa Access  
- 🚗 Airport Pickup  

Each service decorates the base room with additional features, such as changing the description and increasing the cost, without modifying the original room class.

The goal is to demonstrate how you can compose new behavior at runtime using decorators rather than subclassing every possible room-feature combination.

## ✅ Key Features

- ✅ Dynamically adds services without changing the original StandardRoom class

- ✅ Each add-on is implemented as a decorator wrapping an IRoom object

- ✅ Supports flexible feature combinations at runtime

- ✅ Adheres to the Open/Closed Principle — add new features by extension, not modification

- ✅ Great for modeling real-world booking systems and customizable products

# Decorator Pattern Pros & Cons


```
|            Pros                                                                  |                               Cons

| You can extend an object’s behavior without making a new subclass.               |  It’s hard to remove a specific wrapper from the wrappers stack.
| You can add or remove responsibilities from an object at runtime.                | It’s hard to implement a decorator in such a way that its behavior doesn’t depend on the order in the decorators stack.
| You can combine several behaviors by wrapping an object into multiple decorators.| The initial configuration code of layers might look pretty ugly.
| Promotes single responsibility and separation of concerns.                       |  Debugging can be harder due to layered behavior.