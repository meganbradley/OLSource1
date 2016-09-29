---
title: "delegate  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "delegate  (C++ Component Extensions)"
f1_keywords: 
  - "delegate_cpp"
  - "delegate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "delegate keyword [C++]"
ms.assetid: 03caf23d-7873-4a23-9b34-becf42aaf429
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# delegate  (C++ Component Extensions)
Declares a type that represents a function pointer.  
  
## All Runtimes  
 Both the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] and common language runtime support delegates.  
  
### Remarks  
 `delegate` is a context-sensitive keyword. For more information, see [Context-Sensitive Keywords](../VS_csharp/context-sensitive-keywords---c---component-extensions-.md).  
  
 To detect at compile time if a type is a delegate, use the `__is_delegate()` type trait. For more information, see [Compiler Support for Type Traits](../VS_csharp/compiler-support-for-type-traits--c---component-extensions-.md).  
  
## Windows Runtime  
 C++/CX supports delegates with the following syntax.  
  
### Syntax  
  
```cpp  
  
access  
delegate  
return-type  
delegate-type-identifier  
(  
[ parameters ]  
)  
  
```  
  
### Parameters  
 *access*  
 (optional) The accessibility of the delegate, which can be `public` (the default) or `private`. The function prototype can also be qualified with the `const` or `volatile` keywords.  
  
 *return-type*  
 The return type of the function prototype.  
  
 *delegate-type-identifier*  
 The name of the declared delegate type.  
  
 *parameters*  
 (Optional) The types and identifiers of the function prototype.  
  
### Remarks  
 Use the *delegate-type-identifier* to declare an event with the same prototype as the delegate. For more information, see [Delegates (C++/CX)](assetId:///3175bf1c-86d8-4eda-8d8f-c5b6753d8e38).  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
 The common language runtime supports delegates with the following syntax.  
  
### Syntax  
  
```cpp  
  
access  
delegate  
function_declaration  
  
```  
  
### Parameters  
 *access*  
 (optional) The accessibility of the delegate outside of the assembly can be public or private.  The default is private.  Inside a class, a delegate can have any accessibility.  
  
 *function_declaration*  
 The signature of the function that can be bound to the delegate. The return type of a delegate can be any managed type. For interoperability reasons, it is recommended that the return type of a delegate be a CLS type.  
  
 To define an unbound delegate, the first parameter in *function_declaration* should be the type of the `this` pointer for the object. For more information, see [Unbound Delegates](../Topic/Unbound%20Delegates.md).  
  
### Remarks  
 Delegates are multicast: the "function pointer" can be bound to one or more methods within a managed class. The **delegate** keyword defines a multicast delegate type with a specific method signature.  
  
 A delegate can also be bound to a method of a value class, such as a static method.  
  
 A delegate has the following characteristics:  
  
-   It inherits from **System::MulticastDelegate**.  
  
-   It has a constructor that takes two arguments: a pointer to a managed class or **NULL** (in the case of binding to a static method) and a fully qualified method of the specified type.  
  
-   It has a method called `Invoke`, whose signature matches the declared signature of the delegate.  
  
 When a delegate is invoked, its function(s) are called in the order they were attached.  
  
 The return value of a delegate is the return value from its last attached member function.  
  
 Delegates cannot be overloaded.  
  
 Delegates can be bound or unbound.  
  
 When you instantiate a bound delegate, the first argument shall be an object reference.  The second argument of a delegate instantiation shall either be the address of a method of a managed class object, or a pointer to a method of a value type.   The second argument of a delegate instantiation must name the method with the full class scope syntax and apply the address-of operator.  
  
 When you instantiate an unbound delegate, the first argument shall either be the address of a method of a managed class object, or a pointer to a method of a value type.   The argument must name the method with the full class scope syntax and apply the address-of operator.  
  
 When creating a delegate to a static or global function, only one parameter is required: the function (optionally, the address of the function).  
  
 For more information on delegates, see  
  
-   [Unbound Delegates](../Topic/Unbound%20Delegates.md)  
  
-   [How to: Define and Use Delegates](../VS_csharp/how-to--define-and-use-delegates--c---cli-.md)  
  
-   [Delegate to a Member of a Value Class](../Topic/How%20to:%20Associate%20Delegates%20to%20Members%20of%20a%20Value%20Class.md)  
  
-   [Delegate to an Unmanaged Function](../Topic/How%20to:%20Associate%20Delegates%20to%20Unmanaged%20Functions.md)  
  
-   [Composed Delegates](../Topic/How%20to:%20Compose%20Delegates.md)  
  
-   [How to: Pass a Delegate^ to a Native Function Expecting a Function Pointer](../Topic/How%20to:%20Pass%20a%20Delegate%5E%20to%20a%20Native%20Function%20Expecting%20a%20Function%20Pointer.md)  
  
-   [Generic Delegates (C++)](../VS_csharp/generic-delegates--visual-c---.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following example shows how to declare, initialize, and invoke delegates.  
  
```cpp  
// mcppv2_delegate.cpp  
// compile with: /clr  
using namespace System;  
  
// declare a delegate  
public delegate void MyDel(int i);  
  
ref class A {  
public:  
   void func1(int i) {  
      Console::WriteLine("in func1 {0}", i);  
   }  
  
   void func2(int i) {  
      Console::WriteLine("in func2 {0}", i);  
   }  
  
   static void func3(int i) {  
      Console::WriteLine("in static func3 {0}", i);  
   }  
};  
  
int main () {  
   A ^ a = gcnew A;  
  
   // declare a delegate instance  
   MyDel^ DelInst;  
  
   // test if delegate is initialized  
   if (DelInst)  
      DelInst(7);  
  
   // assigning to delegate  
   DelInst = gcnew MyDel(a, &A::func1);  
  
   // invoke delegate  
   if (DelInst)  
      DelInst(8);  
  
   // add a function  
   DelInst += gcnew MyDel(a, &A::func2);  
  
   DelInst(9);  
  
   // remove a function  
   DelInst -= gcnew MyDel(a, &A::func1);  
  
   // invoke delegate with Invoke  
   DelInst->Invoke(10);  
  
   // make delegate to static function  
   MyDel ^ StaticDelInst = gcnew MyDel(&A::func3);  
   StaticDelInst(11);  
}  
```  
  
 **Output**  
  
 **in func1 8**   
 **in func1 9**   
 **in func2 9**   
 **in func2 10**   
 **in static func3 11**   
## See Also  
 [Component Extensions for Runtime Platforms](../VS_csharp/component-extensions-for-runtime-platforms.md)