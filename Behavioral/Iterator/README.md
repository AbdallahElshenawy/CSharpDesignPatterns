# 🔁 Iterator Pattern in C#

## 📌 What is the Iterator Pattern?

The **Iterator** design pattern provides a way to **access elements of a collection sequentially** without exposing the underlying representation.

It decouples the logic of **how the collection is traversed** from the actual **collection data structure**.

It is commonly used when:
- You want to **provide multiple ways of iterating** over a collection (e.g., front-to-back, back-to-front).
- You want to **hide the internal structure** of the collection from consumers.
- You want to **implement custom iteration logic** without polluting the collection class.

---
## ✅ You Should Use the Iterator Pattern When:

- You want to **traverse a collection without exposing its internal structure**.
- You need to **support multiple traversal strategies**.
- You want to **reuse traversal logic** across different types of collections.
- You are designing a custom collection and want to support `foreach` or LINQ.
---

## 🧠 Use Cases of the Iterator Pattern
```
| Use Case                     | Description                                                                  
| 🗂️ Collections in .NET       | IEnumerable and IEnumerator interfaces let you use foreach loops with custom classes. 
| 🎮 Game Engines              | Iterating over objects/entities in a game world without exposing the structure. 
| 📊 GUI Frameworks            | Navigating through UI components like menus, buttons, etc.                         
| 📚 Book Reader App           | Iterating through pages, chapters, or bookmarks.                                    
```
---


## 🚀 Real-World Example: CustomIterableCollection

Imagine you create a **generic collection class** `CustomCollection<T>`. You want to allow iterating it **from front to back** , **from back to front** and **Any custom Iteration u like** without exposing the underlying list structure.

The `Iterator Pattern` enables this separation. The collection remains responsible for storing the items, while different iterators handle how they are accessed.

### ✅ Structure

```| Component               | Description                                                       
| IIterable<T>            | Defines methods like `GetEnumerator()` for iteration.             
| CustomCollection<T>     | Stores items, implements `IEnumerable<T>`, and exposes iterators. 
| FrontToBackEnumerator   | Traverses the collection from start to end.                       
| BackToFrontEnumerator   | Traverses the collection from end to start.                       
| FromToStepEnumerator    | Traverses using a custom range and step value.                    
```

---


## ✅ Key Features

✅ Hides collection structure and logic.

✅ Supports multiple iteration strategies.

✅ Follows Single Responsibility Principle (separates iteration from storage).

✅ Enables clean and readable foreach usage.

---

## 🎯  Iterator Pattern Pros & Cons
```
| Pros                                                     | Cons                                                           
| Decouples collection logic from iteration logic          | May involve creating many extra iterator classes              
| Provides flexibility in traversal strategies             | Slightly increases code complexity                            
| Promotes code reuse and encapsulation                    | Not ideal for very simple collections                         
| Can implement multiple iterators per collection          | Can add overhead if iterators are heavy or inefficient        
    
```

