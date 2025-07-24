# 🌳 Composite Pattern in C#

## 📌 What is the Composite Pattern?

The **Composite** design pattern allows you to **treat individual objects and compositions of objects uniformly**. It is used to represent **part‑whole hierarchies**, where clients can work with both single items and groups of items using the same interface.

---

## 🔍 When to Use the Composite Pattern

- You need to **represent hierarchical structures** (e.g., trees, folders, UI component trees).
- You want clients to **treat individual and composed objects uniformly**.
- You want to build **recursive, nested** object graphs without complex conditional logic.

---

## 🧠 Use Cases of the Composite Pattern



```
| Use Case                     | Description                                                                

|📁 File Systems               | Folders contain files or other folders
|🏢 Company Hierarchies        | Managers have subordinates, who may also be managers
|🧾 UI Components Tree         | Panels contain buttons, text boxes, etc.
|📋 Menus and Submenus         | Menu items may have nested submenus


```
## 📚 Real‑World Example: Course Curriculum Structure

In a learning management system, a **Course** can contain multiple **Modules**, and each **Module** can contain **Lessons** and **Quizzes**.  
Each element—`Course`, `Module`, `Lesson`, `Quiz`—implements a common interface, allowing **recursive** and **flexible** structures. The client interacts with all components uniformly via the same `Display()` method.

---

## 🧱 Pattern Structure in This Example

```plaintext
CourseComponent (abstract)
├── Course      (composite)
│   ├── Module  (composite)
│   │   ├── Lesson (leaf)
│   │   └── Quiz   (leaf)
│   └── Module  (composite)
│       ├── Lesson
│       └── Quiz
└── Course      (composite)  # can nest courses if needed

```
## ✅ Key Features
✅ Uniform Interface: All elements implement `CourseComponent.Display(int depth)`.

✅ Recursive Composition: Course and Module can contain any `CourseComponent`.

✅ Dynamic Structure: You can add or remove modules, lessons, quizzes at runtime.

✅ Client Simplicity: The client calls `root.Display(0)` to render the entire curriculum.

✅ Extensible: Add new types (e.g., `Assignment`, `Project`) by extending `CourseComponent`—no changes to existing code.

---
# 🟢 Composite Pattern Pros & Cons

```
| Pros                                                      | Cons                                        

| Treats simple and complex elements uniformly              | May incur performance overhead in deep trees
| Simplifies client code for tree‑like structures           | Debugging nested structures can be harder 
| Supports recursive composition                            | It might be difficult to provide a common interface for classes whose functionality differs too much.
| Makes it easy to extend with new component types          
