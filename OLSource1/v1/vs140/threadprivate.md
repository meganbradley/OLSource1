---
title: "threadprivate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "threadprivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "threadprivate OpenMP directive"
ms.assetid: 3515aaed-6f9d-4d59-85eb-342378bea2d3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# threadprivate
Specifies that a variable is private to a thread.  
  
## Syntax  
  
```  
#pragma omp threadprivate(var)  
```  
  
## Remarks  
 where,  
  
 `var`  
 A comma-separated list of variables that you want to make private to a thread. `var` must be either a global- or namespace-scoped variable or a local static variable.  
  
## Remarks  
 The `threadprivate` directive supports no OpenMP clauses.  
  
 For more information, see [2.7.1 threadprivate Directive](../vs140/2.7.1-threadprivate-directive.md).  
  
 The `threadprivate` directive is based on the [thread](../vs140/thread.md)`__declspec` attribute; limits on **__declspec(thread)** apply to `threadprivate`.  
  
 You cannot use `threadprivate` in any DLL that will be loaded via [LoadLibrary](http://msdn.microsoft.com/library/windows/desktop/ms684175).  This includes DLLs that are loaded with [/delayload](../vs140/-delayload--delay-load-import-.md), which also uses **LoadLibrary**.  
  
 You can use `threadprivate` in a DLL that is statically loaded at process startup.  
  
 Because `threadprivate` is based on **__declspec(thread)**, a `threadprivate` variable will exist in any thread started in the process, not just those threads that are part of a thread team spawned by a parallel region.  This is an implementation detail that you may want to be aware of, since you may notice, for example, constructors for a `threadprivate` user-defined type called more often then expected.  
  
 A `threadprivate` variable of a destructable type is not guaranteed to have its destructor called.  For example:  
  
```  
struct MyType   
{  
    ~MyType();  
};  
  
MyType threaded_var;  
#pragma omp threadprivate(threaded_var)  
int main()   
{  
    #pragma omp parallel  
    {}  
}  
```  
  
 Users have no control as to when the threads constituting the parallel region will terminate.  If those threads exist when the process exits, the threads will not be notified about the process exit, and the destructor will not be called for `threaded_var` on any thread except the one that exits (here, the primary thread).  So code should not count on proper destruction of `threadprivate` variables.  
  
## Example  
 For a sample of using `threadprivate`, see [private](../vs140/private--openmp-.md).  
  
## See Also  
 [Directives](../vs140/openmp-directives.md)