---
title: "IDebugCustomAttributeQuery2::GetCustomAttributeByName"
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
  - "IDebugCustomAttributeQuery2::GetCustomAttributeByName"
helpviewer_keywords: 
  - "IDebugCustomAttributeQuery2::GetCustomAttributeByName"
ms.assetid: 7428dfeb-8929-41b2-9b99-cb343a86c02d
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttributeQuery2::GetCustomAttributeByName
Obtains the custom attributes bytes given the name of the custom attribute.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A string containing the name of the custom attribute to look for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] An array that is filled in with the custom attribute bytes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Specifies the maximum number of bytes to return in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array and returns the number of bytes actually written to the array.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if the custom attribute does not exist. Otherwise, returns an error code.  
  
## Remarks  
 Set the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter to a null value to return the number of attributes bytes available. Then allocate an array and pass that array in for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
 The attribute bytes represent the raw data of the custom attribute.  
  
 If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameters are set to a null value, this method can be used to determine if the custom attribute merely exists. An easier alternative, however, is to call the [IDebugCustomAttributeQuery2::IsCustomAttributeDefined](../vs140/idebugcustomattributequery2--iscustomattributedefined.md) method.  
  
## See Also  
 [IDebugCustomAttributeQuery2](../vs140/idebugcustomattributequery2.md)   
 [IDebugCustomAttributeQuery2::IsCustomAttributeDefined](../vs140/idebugcustomattributequery2--iscustomattributedefined.md)