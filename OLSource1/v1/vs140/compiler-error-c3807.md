---
title: "Compiler Error C3807"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3807"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3807"
ms.assetid: 7e2b0aab-8c61-4e71-b9c1-fcaeb6a1b5ea
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3807
'type' : a class with the ComImport attribute cannot derive from 'type2', only interface implementation is allowed  
  
 A type that derived from <xref:System.Runtime.InteropServices.ComImportAttribute*> can only implement an interface.  
  
## Example  
 The following sample generates C3807.  
  
```  
// C3807.cpp  
// compile with: /clr /c  
ref struct S {};  
interface struct I {};  
  
[System::Runtime::InteropServices::ComImportAttribute()]  
ref struct S1 : S {};   // C3807  
ref struct S2 : I {};  
```