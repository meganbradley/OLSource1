---
title: "CWinAppEx::GetSectionObject"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CWinAppEx::GetSectionObject"
  - "GetSectionObject"
  - "CWinAppEx.GetSectionObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSectionObject method"
ms.assetid: d229cf56-60d2-4c96-9d39-b1a17fdaa106
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetSectionObject
Reads [CObject](../vs140/cobject-class.md) registry data from the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the value to read.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The method uses this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to store the registry data.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This method reads data from the registry. The data read is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data, or data for a class derived from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. To write <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> data to the registry, use either [CWinAppEx::WriteObject](../vs140/cwinappex--writeobject.md) or [CWinAppEx::WriteSectionObject](../vs140/cwinappex--writesectionobject.md).  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteObject](../vs140/cwinappex--writeobject.md)   
 [CWinAppEx::WriteSectionObject](../vs140/cwinappex--writesectionobject.md)