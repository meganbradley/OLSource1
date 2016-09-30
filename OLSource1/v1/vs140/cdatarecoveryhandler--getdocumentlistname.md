---
title: "CDataRecoveryHandler::GetDocumentListName"
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
  - "GetDocumentListName"
  - "CDataRecoveryHandler::GetDocumentListName"
  - "CDataRecoveryHandler.GetDocumentListName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocumentListName method"
ms.assetid: a4c11c76-54fa-4b97-a42f-925d62ad5743
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::GetDocumentListName
Retrieves the document name from a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> retrieves the document name from this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
  
## Return Value  
 The document name from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> uses the document name as the key in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. These parameter enable the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to monitor <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects, the autosave file name, and the autosave settings.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument Class](../vs140/cdocument-class.md)