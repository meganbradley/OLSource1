---
title: "IDebugDocumentContext2::GetSourceRange"
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
  - "IDebugDocumentContext2::GetSourceRange"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetSourceRange"
ms.assetid: 5903c75e-5390-4d13-9314-1ee276255313
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::GetSourceRange
Gets the source code range of this document context.  
  
## Syntax  
  
```cpp#  
HRESULT GetSourceRange(   
   TEXT_POSITION* pBegPosition,  
   TEXT_POSITION* pEndPosition  
);  
```  
  
```c#  
int GetSourceRange(   
   TEXT_POSITION[] pBegPosition,  
   TEXT_POSITION[] pEndPosition  
);  
```  
  
#### Parameters  
 `pBegPosition`  
 [in, out] A [TEXT_POSITION](../vs140/text_position.md) structure that is filled in with the starting position. Set this argument to a null value if this information is not needed.  
  
 `pEndPosition`  
 [in, out] A [TEXT_POSITION](../vs140/text_position.md) structure that is filled in with the ending position. Set this argument to a null value if this information is not needed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A source range is the entire range of source code, from the current statement back to just after the previous statement that contributed code. The source range is typically used for mixing source statements, including comments, with code in the disassembly window.  
  
 To get the range for just the code statements contained within this document context, call the [GetStatementRange](../vs140/idebugdocumentcontext2--getstatementrange.md) method.  
  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [GetStatementRange](../vs140/idebugdocumentcontext2--getstatementrange.md)   
 [TEXT_POSITION](../vs140/text_position.md)