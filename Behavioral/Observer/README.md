# 🔔 Observer Pattern in C#

## 📌 What is the Observer Pattern?

The **Observer** design pattern is a **behavioral design pattern** that lets you define a **subscription mechanism** to notify **multiple objects** about any **events** that happen to the object they’re observing.

It defines a **one-to-many** relationship between a **Subject** and **Observers**, allowing Observers to automatically receive updates when the Subject's state changes.

It is commonly used when:
- You want to notify multiple objects about changes in another object.
- You want to keep components decoupled and easily extendable.

---

## 🧠 Use Cases of the Observer Pattern



```
| Use Case                     |                              Description 

| 📺 News Subscriptions        | Users subscribe to news channels and get updates when new articles/videos are released

| 📚 Online Courses            | Students get notified when a new lecture is uploaded in a course

| 💬 Chat Applications         | Users in a group chat get notified when someone sends a message

| 🧠 Event Bus / Pub-Sub       | Components react to system-wide events without knowing each other

| 📈 Stock Market Ticker       | Investors get updates when stock prices change 

```
## 🚀 Real-World Example: Online Course Notifications

In this example, we simulate an **online course platform** where students can subscribe to a course and receive notifications whenever a **new lecture** is uploaded.

This simulate real-world educational platforms like **Udemy**, **Coursera**, or **YouTube channel subscriptions**.

### Components:
- **Course (Subject):** Maintains a list of subscribers (students) and notifies them of new lectures.
- **Student (Observer):** Subscribes to courses and receives lecture updates via `Notify()`.
- **UploadLecture():** Changes state and triggers notifications for all subscribers.

---

## ✅ Key Features

- ✅ Decouples subjects and observers using interfaces
- ✅ Students can subscribe/unsubscribe at runtime
- ✅ Notifies all observers of lecture updates without tight coupling
- ✅ Demonstrates real-life use of Observer in modern platforms
- ✅ Follows the Open/Closed Principle (new observers can be added without changing subject code)

---

# 🟢 Observer Pattern Pros & Cons


```
|            Pros                                                                  |                               Cons

|You can establish relations between objects at runtime.                           | Subscribers are notified in random order.
|Promotes loose coupling between subject and observers                             | Observer logic can be hard to debug with many subscribers
|Open/Closed Principle. You can introduce new subscriber classes without having    | May lead to memory leaks if observers aren’t removed properly
 to change the publisher’s code (and vice versa if there’s a publisher interface)