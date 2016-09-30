---
title: "ON_OLECMD"
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
  - "ON_OLECMD_PAGESETUP"
  - "ON_OLECMD_SAVE_AS"
  - "ON_OLECMD_PRINTPREVIEW"
  - "ON_OLECMD_PASTE"
  - "ON_OLECMD_PASTESPECIAL"
  - "ON_OLECMD_NEW"
  - "ON_OLECMD_OPEN"
  - "ON_OLECMD_SELECTALL"
  - "ON_OLECMD_PRINT"
  - "ON_OLECMD_SAVE"
  - "ON_OLECMD_CLEARSELECTION"
  - "ON_OLECMD"
  - "ON_OLECMD_UNDO"
  - "ON_OLECMD_SAVE_COPY_AS"
  - "ON_OLECMD_COPY"
  - "ON_OLECMD_REDO"
  - "ON_OLECMD_CUT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_OLECMD_REDO macro"
  - "ON_OLECMD_NEW macro"
  - "ON_OLECMD_CLEARSELECTION macro"
  - "ON_OLECMD_CUT macro"
  - "ON_OLECMD_COPY macro"
  - "ON_OLECMD_PRINTPREVIEW macro"
  - "ON_OLECMD_SELECTALL macro"
  - "ON_OLECMD_SAVE_COPY_AS macro"
  - "ON_OLECMD_UNDO macro"
  - "ON_OLECMD_SAVE macro"
  - "ON_OLECMD_PASTE macro"
  - "ON_OLECMD_PRINT macro"
  - "ON_OLECMD_PAGESETUP macro"
  - "ON_OLECMD macro"
  - "ON_OLECMD_SAVE_AS macro"
  - "ON_OLECMD_OPEN macro"
  - "ON_OLECMD_PASTESPECIAL macro"
ms.assetid: 6c86327c-3d48-42ac-9dae-e0ccd3a81793
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_OLECMD
Routes commands through the command dispatch interface <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifier of the command group to which the command belongs. Use **NULL** for the standard group.  
  
 *olecmdid*  
 The identifier of the OLE command.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The menu ID, toolbar ID, button ID, or other ID of the resource or object issuing the command.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> allows a container to receive commands that originate in a DocObject's user interface, and allows the container to send the same commands (such as New, Open, SaveAs, and Print on the File menu; and Copy, Paste, Undo, and so forth on the Edit menu) to a DocObject.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is simpler than OLE Automation's <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> relies entirely on a standard set of commands that rarely have arguments, and no type information is involved (type safety is diminished for command arguments as well). If you do need to dispatch commands with arguments, use [COleServerDoc::OnExecOleCmd](../vs140/coleserverdoc--onexecolecmd.md).  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> standard menu commands have been implemented by MFC in the following macros:  
  
 **ON_OLECMD_CLEARSELECTION( )**  
  
 Dispatches the Edit Clear command. Implemented as:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_COPY( )**  
  
 Dispatches the Edit Copy command. Implemented as:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_CUT( )**  
  
 Dispatches the Edit Cut command. Implemented as:  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_NEW( )**  
  
 Dispatches the File New command. Implemented as:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_OPEN( )**  
  
 Dispatches the File Open command. Implemented as:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_PAGESETUP( )**  
  
 Dispatches the File Page Setup command. Implemented as:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_PASTE( )**  
  
 Dispatches the Edit Paste command. Implemented as:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_PASTESPECIAL( )**  
  
 Dispatches the Edit Paste Special command. Implemented as:  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_PRINT( )**  
  
 Dispatches the File Print command. Implemented as:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_PRINTPREVIEW( )**  
  
 Dispatches the File Print Preview command. Implemented as:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_REDO( )**  
  
 Dispatches the Edit Redo command. Implemented as:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_SAVE( )**  
  
 Dispatches the File Save command. Implemented as:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_SAVE_AS( )**  
  
 Dispatches the File Save As command. Implemented as:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_SAVE_COPY_AS( )**  
  
 Dispatches the File Save Copy As command. Implemented as:  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_SELECTALL( )**  
  
 Dispatches the Edit Select All command. Implemented as:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 **ON_OLECMD_UNDO( )**  
  
 Dispatches the Edit Undo command. Implemented as:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleCmdUI Class](../vs140/colecmdui-class.md)   
 [COleServerDoc::OnExecOleCmd](../vs140/coleserverdoc--onexecolecmd.md)