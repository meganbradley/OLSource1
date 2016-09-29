---
title: "Compiler Error CS2036"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS2036"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS2036"
ms.assetid: 44b73be4-b792-4735-bdbd-bd757ab22683
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS2036
The /pdb option requires that the /debug option also be used.  
  
 Program database files are only generated for debug builds. The **/pdb** option is therefore meaningless in a retail build.  
  
### To correct this error  
  
-   Add the **/debug** compiler option.  
  
-   Remove the **/pdb** compiler option.  
  
## Example  
 The following example generates CS2036 when it is compiled with the **/pdb** option but not the /debug option:  
  
```  
// cs2036.cs  
// Compile with: /pdb  
// CS2036  
class Test  
{  
    public static int Main()  
    {  
        return 1;  
    }  
}  
```  
  
## See Also  
 [/pdb (Specify Debug Symbol File) (C# Compiler Options)](../vs140/-pdb--csharp-compiler-options-.md)   
 [/debug (Emit Debugging Information) (C# Compiler Options)](../vs140/-debug--csharp-compiler-options-.md)