---
title: "How to: Define and Use Delegates (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Define and Use Delegates (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "delegates"
ms.assetid: 1cdf3420-89c1-47c0-b796-aa984020e0f8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define and Use Delegates (C++-CLI)
This article shows how to define and consume delegates in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)].  
  
 Although the .NET Framework provides a number of delegates, sometimes you might have to define new delegates.  
  
 The following code example defines a delegate that's named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The event-handling code—the function that's called when this new delegate is fired—must have a return type of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and take a \<xref:System.String*> reference.  
  
 The main function uses a static method that's defined by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to instantiate the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> delegate. The delegate then becomes an alternate method of calling this function, as demonstrated by sending the string "single" to the delegate object. Next, additional instances of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are linked together and then executed by one call to the delegate object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **static SomeClass::Func - single**  
**static SomeClass::Func - chained**  
**static SomeClass::Func - chained**  
**OtherClass::Method - chained, num = 99**  
**OtherClass::Method - chained, num = 100** The next code sample shows how to associate a delegate with a member of a value class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **test**  
**test**   
## How to compose delegates  
 You can use the "<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>" operator to remove a component delegate from a composed delegate.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **Invoking delegate a:**  
**Hello, A!**  
**Invoking delegate b:**  
 **Goodbye, B!**  
**Invoking delegate c:**  
**Hello, C!**  
 **Goodbye, C!**  
**Invoking delegate d:**  
 **Goodbye, D!**   
## Pass a delegate^ to a native function that expects a function pointer  
 From a managed component you can call a native function with function pointer parameters where the native function then can call the member function of the managed component's delegate.  
  
 This sample creates the .dll that exports the native function:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The next sample consumes the .dll and passes a delegate handle to the native function that expects a function pointer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **Call to Managed Function**   
## To associate delegates with unmanaged functions  
 To associate a delegate with a native function, you must wrap the native function in a managed type and declare the function to be invoked through <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **hello**   
## To use unbound delegates  
 You can use an unbound delegate to pass an instance of the type whose function you want to call when the delegate is called.  
  
 Unbound delegates are especially useful if you want to iterate through the objects in a collection—by using [for each, in](../vs140/for-each--in.md) keywords—and call a member function on each instance.  
  
 Here's how to declare, instantiate, and call bound and unbound delegates:  
  
|Action|Bound Delegates|Unbound Delegates|  
|------------|---------------------|-----------------------|  
|Declare|The delegate signature must match the signature of the function you want to call through the delegate.|The first parameter of the delegate signature is the type of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for the object you want to call.\<br />\<br /> After the first parameter, the delegate signature must match the signature of the function you want to call through the delegate.|  
|Instantiate|When you instantiate a bound delegate, you can specify an instance function, or a global or static member function.\<br />\<br /> To specify an instance function, the first parameter is an instance of the type whose member function you want to call and the second parameter is the address of the function you want to call.\<br />\<br /> If you want to call a global or static member function, just pass the name of a global function or the name of the static member function.|When you instantiate an unbound delegate, just pass the address of the function you want to call.|  
|Call|When you call a bound delegate, just pass the parameters that are required by the delegate signature.|Same as a bound delegate, but remember that the first parameter must be an instance of the object that contains the function you want to call.|  
  
 This sample demonstrates how to declare, instantiate, and call unbound delegates:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Output**  
  
 **2**  
**3**  
**2**  
**3**  
**2**  
**7**  
**8**  
**7**  
**8**  
**7** The next sample shows how to use unbound delegates and the [for each, in](../vs140/for-each--in.md) keywords to iterate through objects in a collection and call a member function on each instance.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 This sample creates an unbound delegate to a property's accessor functions:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 **Output**  
  
 **11** The following sample shows how to invoke a multicast delegate, where one instance is bound and one instance is unbound.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **Output**  
  
 **in f(R ^ r)**  
**in f()** The next sample shows how to create and call an unbound generic delegate.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 **Output**  
  
 **12**  
**14**   
## See Also  
 [delegate](../vs140/delegate---c---component-extensions-.md)