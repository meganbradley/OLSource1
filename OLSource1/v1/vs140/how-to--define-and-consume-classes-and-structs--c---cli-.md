---
title: "How to: Define and Consume Classes and Structs (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Define and Consume Classes and Structs (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "structs [C++]"
  - "classes [C++], instantiating"
ms.assetid: 1c03cb0d-1459-4b5e-af65-97d6b3094fd7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define and Consume Classes and Structs (C++-CLI)
This article shows how to define and consume user-defined reference types and value types in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)].  
  
##  \<a name="BKMK_Contents">\</a> Contents  
 [Object instantiation](#BKMK_Object_instantiation)  
  
 [Implicitly abstract classes](#BKMK_Implicitly_abstract_classes)  
  
 [Type visibility](#BKMK_Type_visibility)  
  
 [Member visibility](#BKMK_Member_visibility)  
  
 [Public and private native classes](#BKMK_Public_and_private_native_classes)  
  
 [Static constructors](#BKMK_Static_constructors)  
  
 [Semantics of the this pointer](#BKMK_Semantics_of_the_this_pointer)  
  
 [Hide-by-signature functions](#BKMK_Hide_by_signature_functions)  
  
 [Copy constructors](#BKMK_Copy_constructors)  
  
 [Destructors and finalizers](#BKMK_Destructors_and_finalizers)  
  
##  \<a name="BKMK_Object_instantiation">\</a> Object instantiation  
 Reference (ref) types and value types can only be instantiated on the managed heap, not on the stack or on the native heap.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Implicitly_abstract_classes">\</a> Implicitly abstract classes  
 An *implicitly abstract class* can't be instantiated. A class is implicitly abstract if the base type of the class is an interface and the class does not implement all of the interface's member functions.  
  
 If you are unable to construct objects from a class that's derived from an interface, the reason might be that the class is implicitly abstract. For more information about abstract classes, see [abstract](../vs140/abstract---c---component-extensions-.md).  
  
 The following code example demonstrates that the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class cannot be instantiated because function <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is not implemented. To enable the example to compile, uncomment <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Type_visibility">\</a> Type visibility  
 You can control the visibility of common language runtime (CLR) types so that, if an assembly is referenced, types in the assembly can be visible or not visible outside the assembly.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> indicates that a type is visible to any source file that contains a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> directive for the assembly that contains the type.  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> indicates that a type is not visible to source files that contain a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> directive for the assembly that contains the type. However, private types are visible within the same assembly. By default, the visibility for a class is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 By default prior to Visual C++ 2005, native types had public accessibility outside the assembly. Enable [Compiler Warning (level 1) C4692](../vs140/compiler-warning--level-1--c4692.md) to help you see where private native types are used incorrectly. Use the [make_public](../vs140/make_public.md) pragma to give public accessibility to a native type in a source code file that you can't modify.  
  
 For more information, see [The #using Directive](../vs140/sharpusing-directive--c---.md).  
  
 The following sample shows how to declare types and specify their accessibility, and then access those types inside the assembly. Of course, if an assembly that has private types is referenced by using <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, only public types in the assembly are visible.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **in Public_Class**  
**in Private_Class**  
**in Private_Class_2** Now, let's rewrite the previous sample so that it is built as a DLL.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The next sample shows how to access types outside the assembly. In this sample, the client consumes the component that's built in the previous sample.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **in Public_Class**   
##  \<a name="BKMK_Member_visibility">\</a> Member visibility  
 You can make access to a member of a public class from within the same assembly different than access to it from outside the assembly by using pairs of the access specifiers <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 This table summarizes the effect of the various access specifiers:  
  
|Specifier|Effect|  
|---------------|------------|  
|public|Member is accessible inside and outside the assembly.  See [public (C++)](../vs140/public--c---.md) for more information.|  
|private|Member is not accessible, neither inside nor outside the assembly.  See [private (C++)](../vs140/private--c---.md) for more information.|  
|protected|Member is accessible inside and outside the assembly, but only to derived types.  See [protected (C++)](../vs140/protected--c---.md) for more information.|  
|internal|Member is public inside the assembly but private outside the assembly.  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is a context-sensitive keyword.  For more information, see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md).|  
|public protected -or- protected public|Member is public inside the assembly but protected outside the assembly.|  
|private protected -or- protected private|Member is protected inside the assembly but private outside the assembly.|  
  
 The following sample shows a public type that has members that are declared with the different accessibilities, and then shows the accessing of those members from inside the assembly.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **in Public_Function**  
**in Protected_Public_Function**  
**in Public_Protected_Function**  
**in Internal_Function**  
**=======================**  
**in function of derived class**  
**in Protected_Function**  
**in Protected_Private_Function**  
**in Private_Protected_Function**  
**exiting function of derived class**  
**=======================** Now let's build the previous sample as a DLL.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The following sample consumes the component that's created in the previous sample, and thereby shows how to access the members from outside the assembly.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Output**  
  
 **in Public_Function**  
**=======================**  
**in function of derived class**  
**in Protected_Function**  
**in Protected_Public_Function**  
**in Public_Protected_Function**  
**exiting function of derived class**  
**=======================**   
##  \<a name="BKMK_Public_and_private_native_classes">\</a> Public and private native classes  
 A native type can be referenced from a managed type.  For example, a function in a managed type can take a parameter whose type is a native struct.  If the managed type and function are public in an assembly, then the native type must also be public.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Next, create the source code file that consumes the native type:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Now, compile a client:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Static_constructors">\</a> Static constructors  
 A CLR type—for example, a class or struct—can have a static constructor that can be used to initialize static data members.  A static constructor is called at most once, and is called before any static member of the type is accessed the first time.  
  
 An instance constructor always runs after a static constructor.  
  
 The compiler cannot inline a call to a constructor if the class has a static constructor.  The compiler cannot inline a call to any member function if the class is a value type, has a static constructor, and does not have an instance constructor.  The CLR may inline the call, but the compiler cannot.  
  
 Define a static constructor as a private member function, because it is meant to be called only by the CLR.  
  
 For more information about static constructors, see [Interface Static Constructor](../vs140/how-to--define-an-interface-static-constructor--c---cli-.md) .  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 **Output**  
  
 **in static constructor**  
**10**  
**11**   
##  \<a name="BKMK_Semantics_of_the_this_pointer">\</a> Semantics of the this pointer  
 When you are using Visual C++ to define types, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> pointer in a reference type is of type "handle". The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> pointer in a value type is of type "interior pointer".  
  
 These different semantics of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> pointer can cause unexpected behavior when a default indexer is called. The next example shows the correct way to access a default indexer in both a ref type and a value type.  
  
 For more information, see  
  
-   [^ (Handle to Object on Managed Heap)](../vs140/handle-to-object-operator--^----c---component-extensions-.md)  
  
-   [interior_ptr](../vs140/interior_ptr--c---cli-.md)  
  
-   [How to: Use Indexed Properties](../vs140/how-to--use-indexed-properties.md)  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 **Output**  
  
 **10.89**  
**10.89**   
##  \<a name="BKMK_Hide_by_signature_functions">\</a> Hide-by-signature functions  
 In standard C++, a function in a base class is hidden by a function that has the same name in a derived class, even if the derived-class function does not have the same number or kind of parameters. This is referred to as *hide-by-name* semantics. In a reference type, a function in a base class can only be hidden by a function in a derived class if both the name and the parameter list are the same. This is known as *hide-by-signature* semantics.  
  
 A class is considered a hide-by-signature class when all of its functions are marked in the metadata as <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. By default, all classes that are created under **/clr** have <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> functions. However, a class that's compiled by using **/clr:oldSyntax** does not have <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> functions; instead, they are hide-by-name functions. When a class has <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> functions, the compiler doesn't hide functions by name in any direct base classes, but if the compiler encounters a hide-by-name class in an inheritance chain, it continues that hide-by-name behavior.  
  
 Under hide-by-signature semantics, when a function is called on an object, the compiler identifies the most derived class that contains a function that could satisfy the function call. If there is only one function in the class that could satisfy the call, the compiler calls that function. If there is more than one function in the class that could satisfy the call, the compiler uses overload resolution rules to determine which function to call. For more information about overload rules, see [Function Overloading](../vs140/function-overloading.md).  
  
 For a given function call, a function in a base class might have a signature that makes it a slightly better match than a function in a derived class. However, if the function was explicitly called on an object of the derived class, the function in the derived class is called.  
  
 Because the return value is not considered part of a function's signature, a base-class function is hidden if it has the same name and takes the same number and kind of arguments as a derived-class function, even if it differs in the type of the return value.  
  
 The following sample shows that a function in a base class is not hidden by a function in a derived class.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 **Output**  
  
 **Base::Test** The next sample shows that the Visual C++ compiler calls a function in the most derived class—even if a conversion is required to match one or more of the parameters—and not call a function in a base class that is a better match for the function call.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 **Output**  
  
 **Derived::Test2** The following sample shows that it's possible to hide a function even if the base class has the same signature as the derived class.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 **Output**  
  
 **Derived::Test4**  
**97** The following sample defines a component that's compiled by using **/clr:oldSyntax**. Classes that are defined by using Managed Extensions for C++ have hide-by-name member functions.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The next sample consumes the component that's built in the previous sample. Notice how hide-by-signature functionality is not applied to base classes of types that are compiled by using **/clr:oldSyntax**.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Copy_constructors">\</a> Copy constructors  
 The C++ standard says that a copy constructor is called when an object is moved, such that an object is created and destroyed at the same address.  
  
 However, when **/clr** is used to compile and a function that's compiled to MSIL calls a native function where a native class—or more than one—is passed by value and where the native class has a copy constructor and/or destructor, no copy constructor is called and the object is destroyed at a different address than where it was created. This could cause problems if the class has a pointer into itself, or if the code is tracking objects by address.  
  
 For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
 The following sample demonstrates when a copy constructor is not generated.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 **Output**  
  
 **S object 0 being constructed, this=0018F378**  
**S object 1 being constructed, this=0018F37C**  
**S object 2 being copy constructed from S object 1, this=0018F380**  
**S object 3 being copy constructed from S object 0, this=0018F384**  
**S object 4 being copy constructed from S object 2, this=0018F2E4**  
**S object 2 being destroyed, this=0018F380**  
**S object 5 being copy constructed from S object 3, this=0018F2E0**  
**S object 3 being destroyed, this=0018F384**  
**in function f**  
**S object 5 being destroyed, this=0018F2E0**  
**S object 4 being destroyed, this=0018F2E4**  
**S object 1 being destroyed, this=0018F37C**  
**S object 0 being destroyed, this=0018F378**   
##  \<a name="BKMK_Destructors_and_finalizers">\</a> Destructors and finalizers  
 Destructors in a reference type perform a deterministic clean-up of resources. Finalizers clean up unmanaged resources and can be called deterministically by the destructor or nondeterministically by the garbage collector. For information about destructors in standard C++, see [Destructors (C++)](../vs140/destructors--c---.md).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The behavior of destructors in a managed Visual C++ class differs from Managed Extensions for C++. For more information about this change, see [Changes in Destructor Semantics](../vs140/changes-in-destructor-semantics.md).  
  
 The CLR garbage collector deletes unused managed objects and releases their memory when they are no longer required. However, a type may use resources that the garbage collector does not know how to release. These resources are known as unmanaged resources (native file handles, for example). We recommend that you release all unmanaged resources in the finalizer. Because managed resources are released nondeterministically by the garbage collector, it's not safe to refer to managed resources in a finalizer because it's possible that the garbage collector has already cleaned up that managed resource.  
  
 A Visual C++ finalizer is not the same as the \<xref:System.Object.Finalize*> method. (CLR documentation uses finalizer and the \<xref:System.Object.Finalize*> method synonymously). The \<xref:System.Object.Finalize*> method is called by the garbage collector, which invokes each finalizer in a class inheritance chain. Unlike Visual C++ destructors, a derived-class finalizer call does not cause the compiler to invoke the finalizer in all base classes.  
  
 Because the Visual C++ compiler supports deterministic release of resources, don't try to implement the \<xref:System.IDisposable.Dispose*> or \<xref:System.Object.Finalize*> methods. However, if you're familiar with these methods, here's how a Visual C++ finalizer and a destructor that calls the finalizer map to the \<xref:System.IDisposable.Dispose*> pattern:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A managed type may also use managed resources that you would prefer to release deterministically, and not leave to the garbage collector to release nondeterministically at some point after the object is no longer required. The deterministic release of resources can significantly improve performance.  
  
 The Visual C++ compiler enables the definition of a destructor to deterministically clean up objects. Use the destructor to release all resources that you want to deterministically release.  If a finalizer is present, call it from the destructor, to avoid code duplication.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 If the code that consumes your type does not call the destructor, the garbage collector eventually releases all managed resources.  
  
 The presence of a destructor does not imply the presence of a finalizer. However, the presence of a finalizer implies that you must define a destructor and call the finalizer from that destructor. This provides for the deterministic release of unmanaged resources.  
  
 Calling the destructor suppresses—by using \<xref:System.GC.SuppressFinalize*>—finalization of the object. If the destructor is not called, your type's finalizer will eventually be called by the garbage collector.  
  
 Deterministically cleaning up your object's resources by calling the destructor can improve performance compared with letting the CLR nondeterministically finalize the object.  
  
 Code that's written in Visual C++ and compiled by using **/clr** runs a type's destructor if:  
  
-   An object that's created by using stack semantics goes out of scope. For more information, see [Stack Semantics for Reference Types](../vs140/c---stack-semantics-for-reference-types.md).  
  
-   An exception is thrown during the object's construction.  
  
-   The object is a member in an object whose destructor is running.  
  
-   You call the [delete](../vs140/delete-operator--c---.md) operator on a handle ([^ (Handle to Object on Managed Heap)](../vs140/handle-to-object-operator--^----c---component-extensions-.md)).  
  
-   You explicitly call the destructor.  
  
 If your type is being consumed by a client that's written in another language, the destructor is called as follows:  
  
-   On a call to \<xref:System.IDisposable.Dispose*>.  
  
-   On a call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on the type.  
  
-   If the type goes out of scope in a C# <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> statement.  
  
 If you create an object of a reference type on the managed heap (not using stack semantics for reference types), use [try-finally](../vs140/try-finally-statement.md) syntax to ensure that an exception doesn't prevent the destructor from running.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 If your type has a destructor, the compiler generates a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> method that implements \<xref:System.IDisposable*>. If a type that's written in Visual C++ and has a destructor that's consumed from another language, calling <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> on that type causes the type's destructor to be called. When the type is consumed from a Visual C++ client, you can't directly call <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>; instead, call the destructor by using the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> operator.  
  
 If your type has a finalizer, the compiler generates a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> method that overrides \<xref:System.Object.Finalize*>.  
  
 If a type has either a finalizer or a destructor, the compiler generates a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> method, according to the design pattern. (For information, see [Implementing Finalize and Dispose to Clean Up Unmanaged Resources](assetId:///31a6c13b-d6a2-492b-9a9f-e5238c983bcb)). You cannot explicitly author or call <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> in Visual C++.  
  
 If a type has a base class that conforms to the design pattern, the destructors for all base classes are called when the destructor for the derived class is called. (If your type is written in Visual C++, the compiler ensures that your types implement this pattern.) In other words, the destructor of a reference class chains to its bases and members as specified by the C++ standard—first the class’s destructor is run, then the destructors for its members in the reverse of the order in which they were constructed, and finally the destructors for its base classes in the reverse of the order in which they were constructed.  
  
 Destructors and finalizers are not allowed inside value types or interfaces.  
  
 A finalizer can only be defined or declared in a reference type. Like a constructor and destructor, a finalizer has no return type.  
  
 After an object's finalizer runs, finalizers in any base classes are also called, beginning with the least derived type. Finalizers for data members are not automatically chained to by a class’s finalizer.  
  
 If a finalizer deletes a native pointer in a managed type, you must ensure that references to or through the native pointer are not prematurely collected; call the destructor on the managed type instead of using \<xref:System.GC.KeepAlive*>.  
  
 At compile time, you can detect whether a type has a finalizer or a destructor. For more information, see [Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md).  
  
 The next sample shows two types, one that has unmanaged resources and one that has managed resources that are deterministically released.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
## See Also  
 [Classes and Structs](../vs140/classes-and-structs---c---component-extensions-.md)   
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)