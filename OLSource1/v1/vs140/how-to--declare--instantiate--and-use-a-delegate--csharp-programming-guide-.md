---
title: "How to: Declare, Instantiate, and Use a Delegate (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "delegates [C#], declaring and instantiating"
ms.assetid: 61c4895f-f785-48f8-8bfe-db73b411c4ae
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare, Instantiate, and Use a Delegate (C# Programming Guide)
In C# 1.0 and later, delegates can be declared as shown in the following example.  
  
 [!code[csProgGuideDelegates#13](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideDelegates#14](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_2.cs)]  
  
 C# 2.0 provides a simpler way to write the previous declaration, as shown in the following example.  
  
 [!code[csProgGuideDelegates#32](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_3.cs)]  
  
 In C# 2.0 and later, it is also possible to use an anonymous method to declare and initialize a [delegate](../vs140/delegate--csharp-reference-.md), as shown in the following example.  
  
 [!code[csProgGuideDelegates#15](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_4.cs)]  
  
 In C# 3.0 and later, delegates can also be declared and instantiated by using a lambda expression, as shown in the following example.  
  
 [!code[csProgGuideDelegates#31](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_5.cs)]  
  
 For more information, see [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md).  
  
 The following example illustrates declaring, instantiating, and using a delegate. The `BookDB` class encapsulates a bookstore database that maintains a database of books. It exposes a method, `ProcessPaperbackBooks`, which finds all paperback books in the database and calls a delegate for each one. The `delegate` type that is used is named `ProcessBookDelegate`. The `Test` class uses this class to print the titles and average price of the paperback books.  
  
 The use of delegates promotes good separation of functionality between the bookstore database and the client code. The client code has no knowledge of how the books are stored or how the bookstore code finds paperback books. The bookstore code has no knowledge of what processing is performed on the paperback books after it finds them.  
  
## Example  
 [!code[csProgGuideDelegates#12](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_6.cs)]  
  
## Robust Programming  
  
-   Declaring a delegate.  
  
     The following statement declares a new delegate type.  
  
     [!code[csProgGuideDelegates#16](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_7.cs)]  
  
     Each delegate type describes the number and types of the arguments, and the type of the return value of methods that it can encapsulate. Whenever a new set of argument types or return value type is needed, a new delegate type must be declared.  
  
-   Instantiating a delegate.  
  
     After a delegate type has been declared, a delegate object must be created and associated with a particular method. In the previous example, you do this by passing the `PrintTitle` method to the `ProcessPaperbackBooks` method as in the following example:  
  
     [!code[csProgGuideDelegates#17](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_8.cs)]  
  
     This creates a new delegate object associated with the [static](../vs140/static--csharp-reference-.md) method `Test.PrintTitle`. Similarly, the non-static method `AddBookToTotal` on the object `totaller` is passed as in the following example:  
  
     [!code[csProgGuideDelegates#18](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_9.cs)]  
  
     In both cases a new delegate object is passed to the `ProcessPaperbackBooks` method.  
  
     After a delegate is created, the method it is associated with never changes; delegate objects are immutable.  
  
-   Calling a delegate.  
  
     After a delegate object is created, the delegate object is typically passed to other code that will call the delegate. A delegate object is called by using the name of the delegate object, followed by the parenthesized arguments to be passed to the delegate. Following is an example of a delegate call:  
  
     [!code[csProgGuideDelegates#19](../vs140/codesnippet/CSharp/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-_10.cs)]  
  
     A delegate can be either called synchronously, as in this example, or asynchronously by using `BeginInvoke` and `EndInvoke` methods.  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Events (C#)](../vs140/events--csharp-programming-guide-.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)