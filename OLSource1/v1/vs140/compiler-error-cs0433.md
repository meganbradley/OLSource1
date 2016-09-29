---
title: "Compiler Error CS0433"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0433"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0433"
ms.assetid: efec174a-faa1-4b88-860b-7d9db9c82a02
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0433
The type TypeName1 exists in both TypeName2 and TypeName3  
  
 Two different assemblies referenced in your application contain the same namespace and type, which produces ambiguity.  
  
 To resolve this error, use the alias feature of the [/reference (Import Metadata) (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md) compiler option or do not reference one of your assemblies.  
  
## Example  
 This code creates the DLL with the first copy of the ambiguous type.  
  
```  
// CS0433_1.cs  
// compile with: /target:library  
namespace TypeBindConflicts   
{  
   public class AggPubImpAggPubImp {}  
}  
```  
  
## Example  
 This code creates the DLL with the second copy of the ambiguous type.  
  
```  
// CS0433_2.cs  
// compile with: /target:library  
namespace TypeBindConflicts   
{  
   public class AggPubImpAggPubImp {}  
}  
```  
  
## Example  
 The following example generates CS0433.  
  
```  
// CS0433_3.cs  
// compile with: /reference:cs0433_1.dll /reference:cs0433_2.dll  
using TypeBindConflicts;  
public class Test   
{  
   public static void Main()   
   {  
      AggPubImpAggPubImp n6 = new AggPubImpAggPubImp();   // CS0433  
   }  
}  
```  
  
## Example  
 The following example shows how you can use the alias feature of the **/reference** compiler option to resolve this CS0433 error.  
  
```  
// CS0433_4.cs  
// compile with: /reference:cs0433_1.dll /reference:TypeBindConflicts=cs0433_2.dll  
using TypeBindConflicts;  
public class Test   
{  
   public static void Main()   
   {  
      AggPubImpAggPubImp n6 = new AggPubImpAggPubImp();  
   }  
}  
```