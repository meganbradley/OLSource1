---
title: "Compiler Error CS0413"
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
  - "CS0413"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0413"
ms.assetid: a01bd1ec-015b-433b-be55-b91db268d6a5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0413
The type parameter 'type parameter' cannot be used with the 'as' operator because it does not have a class type constraint nor a 'class' constraint  
  
 This error occurs if a generic type uses the [as](../vs140/as--csharp-reference-.md) operator, but that generic type does not have a class type constraint. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator is only allowed with reference types, so the type parameter must be constrained to guarantee that it is not a value type. To avoid this error, use a class type constraint or a reference type constraint.  
  
 This is because the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator could return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is not a possible value for a value type, and the type parameter must be treated as a value type unless it is a class type constraint or a reference type constraint.  
  
## Example  
 The following sample generates CS0413.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>