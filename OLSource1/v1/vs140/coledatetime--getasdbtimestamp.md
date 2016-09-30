---
title: "COleDateTime::GetAsDBTIMESTAMP"
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
  - "COleDateTime.GetAsDBTIMESTAMP"
  - "ATL.COleDateTime.GetAsDBTIMESTAMP"
  - "COleDateTime::GetAsDBTIMESTAMP"
  - "ATL::COleDateTime::GetAsDBTIMESTAMP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAsDBTIMESTAMP method"
ms.assetid: 8d59a5af-786b-4169-8845-20cebac9fd9e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetAsDBTIMESTAMP
Call this method to obtain the time in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object as a **DBTIMESTAMP** data structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a \<xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Stores the resulting time in the referenced <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure. The **DBTIMESTAMP** data structure initialized by this function will have its **fraction** member set to zero.  
  
## Example  
 [!CODE [NVC_ATLMFC_Utilities#4](NVC_ATLMFC_Utilities#4)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)