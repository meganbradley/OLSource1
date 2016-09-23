---
title: "Compiler Warning (level 1) CS0824"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS0824
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0824
ms.assetid: ad643bb7-51b2-455b-a9f3-2bd4588d2c5d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS0824
Constructor 'name' is marked external.  
  
 A constructor may be marked as extern. However, the compiler cannot verify that the constructor actually exists. Therefore the warning is generated.  
  
### To remove this warning  
  
1.  Use a pragma warning directive to ignore it.  
  
2.  Move the constructor inside the type.  
  
## Example  
 The following code generates CS0824:  
  
```  
// cs0824.cs  
public class C  
{  
    extern C(); // CS0824  
    public static int Main()  
    {  
        return 1;  
    }  
}  
```  
  
## See Also  
 [extern (C# Reference)](../vs140/extern--csharp-reference-.md)   
 [#pragma warning (C# Reference)](../vs140/sharppragma-warning--csharp-reference-.md)