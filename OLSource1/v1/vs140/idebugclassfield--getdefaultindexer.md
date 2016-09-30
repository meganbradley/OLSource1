---
title: "IDebugClassField::GetDefaultIndexer"
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
  - "IDebugClassField::GetDefaultIndexer"
helpviewer_keywords: 
  - "IDebugClassField::GetDefaultIndexer method"
ms.assetid: 47ce4f45-3816-4b40-909c-5032d0692d75
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::GetDefaultIndexer
Gets the name of the default indexer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a string containing the name of the default indexer.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there is no default indexer. Otherwise, returns an error code.  
  
## Remarks  
 The default indexer of a class is the property that is marked as the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> property for array accesses. This is specific to [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. Here is an example of a default indexer declared in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] and how it is used.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugClassField](../vs140/idebugclassfield.md)