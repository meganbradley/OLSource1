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
Routes commands through the command dispatch interface `IOleCommandTarget`.  
  
## Syntax  
  
```  
  
ON_OLECMD(  
pguid  
,   
olecmdid  
,   
id )  
```  
  
#### Parameters  
 `pguid`  
 Identifier of the command group to which the command belongs. Use **NULL** for the standard group.  
  
 *olecmdid*  
 The identifier of the OLE command.  
  
 `id`  
 The menu ID, toolbar ID, button ID, or other ID of the resource or object issuing the command.  
  
## Remarks  
 `IOleCommandTarget` allows a container to receive commands that originate in a DocObject's user interface, and allows the container to send the same commands (such as New, Open, SaveAs, and Print on the File menu; and Copy, Paste, Undo, and so forth on the Edit menu) to a DocObject.  
  
 `IOleCommandTarget` is simpler than OLE Automation's `IDispatch`. `IOleCommandTarget` relies entirely on a standard set of commands that rarely have arguments, and no type information is involved (type safety is diminished for command arguments as well). If you do need to dispatch commands with arguments, use [COleServerDoc::OnExecOleCmd](../vs140/coleserverdoc--onexecolecmd.md).  
  
 The `IOleCommandTarget` standard menu commands have been implemented by MFC in the following macros:  
  
 **ON_OLECMD_CLEARSELECTION( )**  
  
 Dispatches the Edit Clear command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_CLEARSELECTION, ID_EDIT_CLEAR)`  
  
 **ON_OLECMD_COPY( )**  
  
 Dispatches the Edit Copy command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_COPY, ID_EDIT_COPY)`  
  
 **ON_OLECMD_CUT( )**  
  
 Dispatches the Edit Cut command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_CUT, ID_EDIT_CUT)`  
  
 **ON_OLECMD_NEW( )**  
  
 Dispatches the File New command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_NEW, ID_FILE_NEW)`  
  
 **ON_OLECMD_OPEN( )**  
  
 Dispatches the File Open command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_OPEN, ID_FILE_OPEN)`  
  
 **ON_OLECMD_PAGESETUP( )**  
  
 Dispatches the File Page Setup command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_PAGESETUP, ID_FILE_PAGE_SETUP)`  
  
 **ON_OLECMD_PASTE( )**  
  
 Dispatches the Edit Paste command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_PASTE, ID_EDIT_PASTE)`  
  
 **ON_OLECMD_PASTESPECIAL( )**  
  
 Dispatches the Edit Paste Special command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_PASTESPECIAL, ID_EDIT_PASTE_SPECIAL)`  
  
 **ON_OLECMD_PRINT( )**  
  
 Dispatches the File Print command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_PRINT, ID_FILE_PRINT)`  
  
 **ON_OLECMD_PRINTPREVIEW( )**  
  
 Dispatches the File Print Preview command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_PRINTPREVIEW, ID_FILE_PRINT_PREVIEW)`  
  
 **ON_OLECMD_REDO( )**  
  
 Dispatches the Edit Redo command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_REDO, ID_EDIT_REDO)`  
  
 **ON_OLECMD_SAVE( )**  
  
 Dispatches the File Save command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_SAVE, ID_FILE_SAVE)`  
  
 **ON_OLECMD_SAVE_AS( )**  
  
 Dispatches the File Save As command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_SAVEAS, ID_FILE_SAVE_AS)`  
  
 **ON_OLECMD_SAVE_COPY_AS( )**  
  
 Dispatches the File Save Copy As command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_SAVECOPYAS, ID_FILE_SAVE_COPY_AS)`  
  
 **ON_OLECMD_SELECTALL( )**  
  
 Dispatches the Edit Select All command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_SELECTALL, ID_EDIT_SELECT_ALL)`  
  
 **ON_OLECMD_UNDO( )**  
  
 Dispatches the Edit Undo command. Implemented as:  
  
 `ON_OLECMD(NULL, OLECMDID_UNDO, ID_EDIT_UNDO)`  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleCmdUI Class](../vs140/colecmdui-class.md)   
 [COleServerDoc::OnExecOleCmd](../vs140/coleserverdoc--onexecolecmd.md)