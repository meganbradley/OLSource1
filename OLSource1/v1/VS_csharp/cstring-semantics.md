---
title: "CString Semantics"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "semantics in Cstring"
  - "CString objects, assignment semantics"
  - "assignment statements, assigning CString objects"
ms.assetid: d4023480-526f-499a-85f6-324b4de5b85f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CString Semantics
Even though [CString](../VS_csharp/cstringt-class.md) objects are dynamic objects that can grow, they act like built-in primitive types and simple classes. Each `CString` object represents a unique value. `CString` objects should be thought of as the actual strings rather than as pointers to strings.  
  
 You can assign one **CString** object to another. However, when you modify one of the two `CString` objects, the other `CString` object is not modified, as shown by the following example:  
  
 [!code[NVC_ATLMFC_Utilities#188](../VS_csharp/codesnippet/CPP/cstring-semantics_1.cpp)]  
  
 Note in the example that the two `CString` objects are considered "equal" because they represent the same character string. The `CString` class overloads the equality operator (`==`) to compare two `CString` objects based on their value (contents) rather than their identity (address).  
  
## See Also  
 [Strings (ATL/MFC)](../VS_csharp/strings--atl-mfc-.md)