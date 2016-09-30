---
title: "IDebugSymbolProvider::GetClassTypeByName"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugSymbolProvider::GetClassTypeByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetClassTypeByName method"
ms.assetid: 2c748909-51dc-49b7-b193-19f96fca1138
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetClassTypeByName
This method gets the class field type representing a fully qualified class name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The class name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../vs140/name_match.md) enumeration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the class type as represented by the [IDebugClassField](../vs140/idebugclassfield.md) interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [NAME_MATCH](../vs140/name_match.md)   
 [IDebugClassField](../vs140/idebugclassfield.md)