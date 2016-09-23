---
title: "CA1812: Avoid uninstantiated internal classes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CA1812
  - AvoidUninstantiatedInternalClasses
helpviewer_keywords: 
  - AvoidUninstantiatedInternalClasses
  - CA1812
ms.assetid: 1bb92a42-322a-44cc-98a8-8858212c1e1f
caps.latest.revision: 30
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA1812: Avoid uninstantiated internal classes
|||  
|-|-|  
|TypeName|AvoidUninstantiatedInternalClasses|  
|CheckId|CA1812|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 An instance of an assembly-level type is not created by code in the assembly.  
  
## Rule Description  
 This rule tries to locate a call to one of the constructors of the type, and reports a violation if no call is found.  
  
 The following types are not examined by this rule:  
  
-   Value types  
  
-   Abstract types  
  
-   Enumerations  
  
-   Delegates  
  
-   Compiler-emitted array types  
  
-   Types that cannot be instantiated and that define `static` (`Shared` in Visual Basic) methods only.  
  
 If you apply <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute?qualifyHint=True> to the assembly that is being analyzed, this rule will not occur on any constructors that are marked as `internal` because you cannot tell whether a field is being used by another `friend` assembly.  
  
 Even though you cannot work around this limitation in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Code Analysis, the external stand-alone FxCop will occur on internal constructors if every `friend` assembly is present in the analysis.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the type or add the code that uses it. If the type contains only static methods, add one of the following to the type to prevent the compiler from emitting a default public instance constructor:  
  
-   A private constructor for types that target [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] versions 1.0 and 1.1.  
  
-   The `static` (`Shared` in Visual Basic) modifier for types that target [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)].  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule. We recommend that you suppress this warning in the following situations:  
  
-   The class is created through late-bound reflection methods such as <xref:System.Activator.CreateInstance?qualifyHint=True>.  
  
-   The class is created automatically by the runtime or [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)]. For example, classes that implement <xref:System.Configuration.IConfigurationSectionHandler?qualifyHint=True> or <xref:System.Web.IHttpHandler?qualifyHint=True>.  
  
-   The class is passed as a generic type parameter that has a new constraint. For example, the following example will raise this rule.  
  
    ```c#  
    internal class MyClass  
    {     
        public DoSomething()     
        {  
        }  
    }   
    public class MyGeneric<T> where T : new()  
    {  
        public T Create()  
        {  
            return new T();     
        }  
    }  
    // [...]   
    MyGeneric<MyClass> mc = new MyGeneric<MyClass>();  
    mc.Create();  
    ```  
  
 In these situations, we recommended you suppress this warning.  
  
## Related Rules  
 [Avoid uncalled private code](../vs140/ca1811--avoid-uncalled-private-code.md)  
  
 [Avoid unused parameters](../vs140/ca1801--review-unused-parameters.md)  
  
 [Remove unused locals](../vs140/ca1804--remove-unused-locals.md)