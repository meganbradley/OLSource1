---
title: "ICommandTextImpl Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ICommandText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ICommandText class"
ms.assetid: 9c2715cc-1e55-4468-8327-85341617ed46
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandTextImpl Class
Provides an implementation for the [ICommandText](https://msdn.microsoft.com/en-us/library/ms714914.aspx) interface.  
  
## Syntax  
  
```  
template <class T >  
class ATL_NO_VTABLE ICommandTextImpl   
   : public ICommandImpl<T, ICommandText>  
```  
  
#### Parameters  
 `T`  
 The command class derived from **ICommandTextImpl**.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[GetCommandText](../vs140/icommandtextimpl--getcommandtext.md)|Returns the text command set by the last call to [SetCommandText](../vs140/icommandtextimpl--setcommandtext.md).|  
|[SetCommandText](../vs140/icommandtextimpl--setcommandtext.md)|Sets the command text, replacing the existing command text.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_strCommandText](../vs140/icommandtextimpl--m_strcommandtext.md)|Stores the command text.|  
  
## Remarks  
 A mandatory interface on commands.  
  
## Requirements  
 **Header:** altdb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)