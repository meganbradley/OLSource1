---
title: "CDatabase::SetLoginTimeout"
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
  - "CDatabase.SetLoginTimeout"
  - "CDatabase::SetLoginTimeout"
  - "SetLoginTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, database attributes"
  - "SetLoginTimeout method"
ms.assetid: 7a670f50-0481-4cb0-8e98-2cbe3bef23bc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::SetLoginTimeout
Call this member function — before you call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or **Open** — to override the default number of seconds allowed before an attempted data source connection times out.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of seconds to allow before a connection attempt times out.  
  
## Remarks  
 A connection attempt might time out if, for example, the DBMS is not available. Call **SetLoginTimeout** after you construct the uninitialized <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object but before you call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or **Open**.  
  
 The default value for login timeouts is 15 seconds. Not all data sources support the ability to specify a login timeout value. If the data source does not support timeout, you get trace output but not an exception. A value of 0 means "infinite."  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OnSetOptions](../vs140/cdatabase--onsetoptions.md)   
 [CDatabase::SetQueryTimeout](../vs140/cdatabase--setquerytimeout.md)