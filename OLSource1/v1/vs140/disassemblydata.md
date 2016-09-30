---
title: "DisassemblyData"
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
  - "DisassemblyData"
helpviewer_keywords: 
  - "DisassemblyData structure"
ms.assetid: 10e70aa7-9381-40d3-bdd1-d2cad78ef16c
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DisassemblyData
Describes one disassembly instruction for the integrated development environment (IDE) to display.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The [DISASSEMBLY_STREAM_FIELDS](../vs140/disassembly_stream_fields.md) constant that specifies which fields are filled out.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The address as an offset from some starting point (usually the beginning of the associated function).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The code bytes for this instruction.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The opcode for this instruction.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The operands for this instruction.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The symbol name, if any, associated with the address (public symbol, label, and so on).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The code location identifier for this disassembled line. If the code context address of one line is greater than the code context address of another, then the disassembled code location identifier of the first will also be greater than the code location identifier of the second.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The [TEXT_POSITION](../vs140/text_position.md) that corresponds to the position in a document where the disassembly data begins.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The [TEXT_POSITION](../vs140/text_position.md) that corresponds to the position in a document where the disassembly data ends.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 For text documents that can be represented as file names, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field is filled in with the file name where the source can be found, using the format <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 For text documents that cannot be represented as file names, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a unique identifier for the document, and the debug engine must implement the [GetDocument](../vs140/idebugdisassemblystream2--getdocument.md) method.  
  
 This field can also contain additional information about checksums. See Remarks for details.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The number of bytes the instruction is from the beginning of the code line.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The [DISASSEMBLY_FLAGS](../vs140/disassembly_flags.md) constant that specifies which flags are active.  
  
## Remarks  
 Each <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure describes one instruction of disassembly. An array of these structures is returned from the [Read](../vs140/idebugdisassemblystream2--read.md) method.  
  
 The [TEXT_POSITION](../vs140/text_position.md) structure is used for text-based documents only. The source code range for this instruction is filled out only for the first instruction generated from a statement or line, for example, when <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 For documents that are non-textual, a document context can be obtained from the code, and the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> field should be a null value. If the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> field is the same as the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> field in the previous <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> array element, then set the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to a null value.  
  
 If the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> field has the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> flag set, then additional checksum information follows the string pointed to by the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> field. Specifically, after the null string terminator, there follows a GUID identifying the checksum algorithm that is in turn followed by a 4 byte value indicating the number of bytes in the checksum and that in turn is followed by the checksum bytes. See the Example in this topic on how to encode and decode this field in [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)].  
  
## Example  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> field can contain additional information other than a string if the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> flag is set. The process of creating and reading this encoded string is straightforward in [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)]. However, in [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)], it is another matter. For those who are curious, the following example shows one way to create the encoded string from [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] and one way to decode the encoded string in [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)].  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [Read](../vs140/idebugdisassemblystream2--read.md)   
 [DISASSEMBLY_STREAM_FIELDS](../vs140/disassembly_stream_fields.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [TEXT_POSITION](../vs140/text_position.md)   
 [DISASSEMBLY_FLAGS](../vs140/disassembly_flags.md)