---
title: "Destructors (C# Programming Guide)"
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
  - "~ [C#], in destructors"
  - "C# language, destructors"
  - "destructors [C#]"
ms.assetid: 1ae6e46d-a4b1-4a49-abe5-b97f53d9e049
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Destructors (C# Programming Guide)
Destructors are used to destruct instances of classes.  
  
## Remarks  
  
-   Destructors cannot be defined in structs. They are only used with classes.  
  
-   A class can only have one destructor.  
  
-   Destructors cannot be inherited or overloaded.  
  
-   Destructors cannot be called. They are invoked automatically.  
  
-   A destructor does not take modifiers or have parameters.  
  
 For example, the following is a declaration of a destructor for the class `Car`:  
  
 [!code[csProgGuideObjects#86](../vs140/codesnippet/CSharp/destructors--csharp-programming-guide-_1.cs)]  
  
 The destructor implicitly calls <xref:System.Object.Finalize*> on the base class of the object. Therefore, the previous destructor code is implicitly translated to the following code:  
  
```  
protected override void Finalize()  
{  
    try  
    {  
        // Cleanup statements...  
    }  
    finally  
    {  
        base.Finalize();  
    }  
}  
```  
  
 This means that the `Finalize` method is called recursively for all instances in the inheritance chain, from the most-derived to the least-derived.  
  
> [!NOTE]
>  Empty destructors should not be used. When a class contains a destructor, an entry is created in the `Finalize` queue. When the destructor is called, the garbage collector is invoked to process the queue. If the destructor is empty, this just causes a needless loss of performance.  
  
 The programmer has no control over when the destructor is called because this is determined by the garbage collector. The garbage collector checks for objects that are no longer being used by the application. If it considers an object eligible for destruction, it calls the destructor (if any) and reclaims the memory used to store the object. Destructors are also called when the program exits.  
  
 It is possible to force garbage collection by calling <xref:System.GC.Collect*>, but most of the time, this should be avoided because it may create performance issues.  
  
## Using Destructors to Release Resources  
 In general, C# does not require as much memory management as is needed when you develop with a language that does not target a runtime with garbage collection. This is because the .NET Framework garbage collector implicitly manages the allocation and release of memory for your objects. However, when your application encapsulates unmanaged resources such as windows, files, and network connections, you should use destructors to free those resources. When the object is eligible for destruction, the garbage collector runs the `Finalize` method of the object.  
  
## Explicit Release of Resources  
 If your application is using an expensive external resource, we also recommend that you provide a way to explicitly release the resource before the garbage collector frees the object. You do this by implementing a `Dispose` method from the <xref:System.IDisposable*> interface that performs the necessary cleanup for the object. This can considerably improve the performance of the application. Even with this explicit control over resources, the destructor becomes a safeguard to clean up resources if the call to the `Dispose` method failed.  
  
 For more details about cleaning up resources, see the following topics:  
  
-   [Cleaning Up Unmanaged Resources](assetId:///a17b0066-71c2-4ba4-9822-8e19332fc213)  
  
-   [Implementing a Dispose Method](assetId:///eb4e1af0-3b48-4fbc-ad4e-fc2f64138bf9)  
  
-   [using Statement (C# Programmer's Reference)](../vs140/using-statement--csharp-reference-.md)  
  
## Example  
 The following example creates three classes that make a chain of inheritance. The class `First` is the base class, `Second` is derived from `First`, and `Third` is derived from `Second`. All three have destructors. In `Main()`, an instance of the most-derived class is created. When the program runs, notice that the destructors for the three classes are called automatically, and in order, from the most-derived to the least-derived.  
  
 [!code[csProgGuideObjects#85](../vs140/codesnippet/CSharp/destructors--csharp-programming-guide-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.IDisposable*>   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Programming Essentials for Garbage Collection](assetId:///22b6cb97-0c80-4eeb-a2cf-5ed7655e37f9)