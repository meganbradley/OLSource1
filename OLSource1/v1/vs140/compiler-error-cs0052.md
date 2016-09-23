---
title: "Compiler Error CS0052"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - CS0052
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0052
ms.assetid: 3beed1c9-f482-4a48-b98d-b9fdc279b9d7
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0052
Inconsistent accessibility: field type 'type' is less accessible than field 'field'  
  
 The type of a field cannot be less accessible than the field itself because all public constructs must return a publicly accessible object.  
  
## Example  
 The following sample generates CS0052:  
  
```c#  
// CS0052.cs  
public class MyClass2  
{  
    // The following line causes an error because the field, M, is declared  
    // as public, but the type, MyClass, is private. Therefore the type is   
    // less accessible than the field.  
    public MyClass M;   // CS0052  
  
    private class MyClass  
    {  
    }  
    // One way to resolve the error is to change the accessibility of the type  
    // to public.   
    //public class MyClass  
    // Another solution is to change the accessibility of the field to private.  
    // private MyClass M;  
}  
  
    public class MainClass  
    {  
        public static void Main()  
        {  
        }  
    }  
```  
  
## See Also  
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)