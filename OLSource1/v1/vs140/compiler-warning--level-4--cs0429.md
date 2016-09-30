---
title: "Compiler Warning (level 4) CS0429"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0429"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0429"
ms.assetid: 906442de-9760-4e28-aea1-c94f0af918fb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) CS0429
Unreachable expression code detected  
  
 This error occurs whenever part of an expression in your code is unreachable. In the following example, the condition `false && myTest()` meets this criteria because the `myTest()` method will never get evaluated due to the fact that the left side of the `&&` operation is always false. As soon as the `&&` operator evaluates the `false` statement as false, it stops the evaluation, and will never evaluate the right side.  
  
## Example  
 The following code generates CS0429.  
  
```  
// CS0429.cs  
public class cs0429   
{  
    public static void Main()   
    {  
        if (false && myTest())  // CS0429  
        // Try the following line instead:  
        // if (true && myTest())  
        {  
        }  
        else  
        {  
            int i = 0;  
            i++;  
        }  
    }  
  
    static bool myTest() { return true; }  
}  
```