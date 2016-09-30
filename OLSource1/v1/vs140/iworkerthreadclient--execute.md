---
title: "IWorkerThreadClient::Execute"
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
  - "IWorkerThreadClient::Execute"
  - "ATL.IWorkerThreadClient.Execute"
  - "IWorkerThreadClient.Execute"
  - "ATL::IWorkerThreadClient::Execute"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Execute method"
ms.assetid: 86e156d6-1f65-400a-9a1e-640b8b638bd8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IWorkerThreadClient::Execute
Implement this method to execute code when the handle associated with this object becomes signaled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The user parameter.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The handle that has become signaled.  
  
## Return Value  
 Return S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The handle and DWORD/pointer passed to this method were previously associated with this object by a call to [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md).  
  
## Example  
 The following code shows a simple implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATL_Utilities#136](../vs140/codesnippet/CPP/iworkerthreadclient--execute_1.cpp)]  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [IWorkerThreadClient Interface](../vs140/iworkerthreadclient-interface.md)   
 [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md)