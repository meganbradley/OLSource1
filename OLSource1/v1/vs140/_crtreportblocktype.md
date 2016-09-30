---
title: "_CrtReportBlockType"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_CrtReportBlockType"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CrtReportBlockType"
  - "CrtReportBlockType"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtReportBlockType function"
  - "BLOCK_SUBTYPE macro"
  - "_CrtReportBlockType function"
  - "_BLOCK_TYPE macro"
  - "_BLOCK_SUBTYPE macro"
  - "BLOCK_TYPE macro"
ms.assetid: 0f4b9da7-bebb-4956-9541-b2581640ec6b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtReportBlockType
Returns the block type/subtype associated with a given debug heap block pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pBlock*  
 Pointer to a valid debug heap block.  
  
## Return Value  
 When passed a valid debug heap pointer, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function returns the block type and subtype in the form of an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When passed an invalid pointer, the function returns -1.  
  
## Remarks  
 To extract the type and subtype returned by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, use the macros **_BLOCK_TYPE** and **_BLOCK_SUBTYPE** (both defined in Crtdbg.h) on the return value.  
  
 For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [_CrtDoForAllClientObjects](../vs140/_crtdoforallclientobjects.md)   
 [_CrtSetDumpClient](../vs140/_crtsetdumpclient.md)   
 [_CrtMemDumpAllObjectsSince](../vs140/_crtmemdumpallobjectssince.md)   
 [_CrtDumpMemoryLeaks](../vs140/_crtdumpmemoryleaks.md)