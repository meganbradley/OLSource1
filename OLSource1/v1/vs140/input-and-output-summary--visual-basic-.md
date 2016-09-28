---
title: "Input and Output Summary (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "input, Visual Basic functions"
  - "output, Visual Basic functions"
  - "I/O [Visual Basic], functions"
ms.assetid: 6b0cbb88-6593-43b8-8a40-a61563bc0ce9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input and Output Summary (Visual Basic)
Visual Basic language keywords and run-time library members are organized by purpose and use.  
  
|Action|Language element|  
|------------|----------------------|  
|Access or create a file.|[FileOpen](assetId:///M:Microsoft.VisualBasic.FileSystem.FileOpen(System.Int32,System.String,Microsoft.VisualBasic.OpenMode,Microsoft.VisualBasic.OpenAccess,Microsoft.VisualBasic.OpenShare,System.Int32)?qualifyHint=False&autoUpgrade=True)|  
|Close files.|[FileClose](assetId:///M:Microsoft.VisualBasic.FileSystem.FileClose(System.Int32[])?qualifyHint=False&autoUpgrade=True), <xref:Microsoft.VisualBasic.FileSystem.Reset*>|  
|Control output appearance.|[Format](assetId:///M:Microsoft.VisualBasic.Strings.Format(System.Object,System.String)?qualifyHint=False&autoUpgrade=True), [Print](assetId:///M:Microsoft.VisualBasic.FileSystem.Print(System.Int32,System.Object[])?qualifyHint=False&autoUpgrade=True), [SPC](assetId:///M:Microsoft.VisualBasic.FileSystem.SPC(System.Int16)?qualifyHint=False&autoUpgrade=True), <xref:Microsoft.VisualBasic.FileSystem.TAB*>, [FileWidth](assetId:///M:Microsoft.VisualBasic.FileSystem.FileWidth(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)|  
|Copy a file.|[FileCopy](assetId:///M:Microsoft.VisualBasic.FileSystem.FileCopy(System.String,System.String)?qualifyHint=False&autoUpgrade=True)|  
|Get information about a file.|[EOF](assetId:///M:Microsoft.VisualBasic.FileSystem.EOF(System.Int32)?qualifyHint=False&autoUpgrade=True), [FileAttr](assetId:///M:Microsoft.VisualBasic.FileSystem.FileAttr(System.Int32)?qualifyHint=False&autoUpgrade=True), [FileDateTime](assetId:///M:Microsoft.VisualBasic.FileSystem.FileDateTime(System.String)?qualifyHint=False&autoUpgrade=True), [FileLen](assetId:///M:Microsoft.VisualBasic.FileSystem.FileLen(System.String)?qualifyHint=False&autoUpgrade=True), <xref:Microsoft.VisualBasic.FileSystem.FreeFile*>, [GetAttr](assetId:///M:Microsoft.VisualBasic.FileSystem.GetAttr(System.String)?qualifyHint=False&autoUpgrade=True), [Loc](assetId:///M:Microsoft.VisualBasic.FileSystem.Loc(System.Int32)?qualifyHint=False&autoUpgrade=True), [LOF](assetId:///M:Microsoft.VisualBasic.FileSystem.LOF(System.Int32)?qualifyHint=False&autoUpgrade=True), [Seek](assetId:///M:Microsoft.VisualBasic.FileSystem.Seek(System.Int32)?qualifyHint=False&autoUpgrade=True)|  
|Get or provide information from/to the user by means of a control dialog box.|[InputBox](assetId:///M:Microsoft.VisualBasic.Interaction.InputBox(System.String,System.String,System.String,System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True), [MsgBox](assetId:///M:Microsoft.VisualBasic.Interaction.MsgBox(System.Object,Microsoft.VisualBasic.MsgBoxStyle,System.Object)?qualifyHint=False&autoUpgrade=True)|  
|Manage files.|<xref:Microsoft.VisualBasic.FileSystem.Dir*>, [Kill](assetId:///M:Microsoft.VisualBasic.FileSystem.Kill(System.String)?qualifyHint=False&autoUpgrade=True), [Lock](assetId:///M:Microsoft.VisualBasic.FileSystem.Lock(System.Int32)?qualifyHint=False&autoUpgrade=True), [Unlock](assetId:///M:Microsoft.VisualBasic.FileSystem.Unlock(System.Int32)?qualifyHint=False&autoUpgrade=True)|  
|Read from a file.|[FileGet](assetId:///M:Microsoft.VisualBasic.FileSystem.FileGet(System.Int32,System.String@,System.Int64,System.Boolean)?qualifyHint=False&autoUpgrade=True), [FileGetObject](assetId:///M:Microsoft.VisualBasic.FileSystem.FileGetObject(System.Int32,System.Object@,System.Int64)?qualifyHint=False&autoUpgrade=True), [Input](assetId:///M:Microsoft.VisualBasic.FileSystem.Input(System.Int32,System.String@)?qualifyHint=False&autoUpgrade=True), [InputString](assetId:///M:Microsoft.VisualBasic.FileSystem.InputString(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True), [LineInput](assetId:///M:Microsoft.VisualBasic.FileSystem.LineInput(System.Int32)?qualifyHint=False&autoUpgrade=True)|  
|Return length of a file.|assetId:///M:Microsoft.VisualBasic.FileSystem.FileLen(System.String)?qualifyHint=False&autoUpgrade=True|  
|Set or get file attributes.|assetId:///M:Microsoft.VisualBasic.FileSystem.FileAttr(System.Int32)?qualifyHint=False&autoUpgrade=True, assetId:///M:Microsoft.VisualBasic.FileSystem.GetAttr(System.String)?qualifyHint=False&autoUpgrade=True, [SetAttr](assetId:///M:Microsoft.VisualBasic.FileSystem.SetAttr(System.String,Microsoft.VisualBasic.FileAttribute)?qualifyHint=False&autoUpgrade=True)|  
|Set read-write position in a file.|assetId:///M:Microsoft.VisualBasic.FileSystem.Seek(System.Int32)?qualifyHint=False&autoUpgrade=True|  
|Write to a file.|[FilePut](assetId:///M:Microsoft.VisualBasic.FileSystem.FilePut(System.Object,System.Object,System.Object)?qualifyHint=False&autoUpgrade=True), [FilePutObject](assetId:///M:Microsoft.VisualBasic.FileSystem.FilePutObject(System.Int32,System.Object,System.Int64)?qualifyHint=False&autoUpgrade=True), assetId:///M:Microsoft.VisualBasic.FileSystem.Print(System.Int32,System.Object[])?qualifyHint=False&autoUpgrade=True, [Write](assetId:///M:Microsoft.VisualBasic.FileSystem.Write(System.Int32,System.Object[])?qualifyHint=False&autoUpgrade=True), [WriteLine](assetId:///M:Microsoft.VisualBasic.FileSystem.WriteLine(System.Int32,System.Object[])?qualifyHint=False&autoUpgrade=True)|  
  
## See Also  
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Visual Basic Runtime Library Members](../vs140/visual-basic-runtime-library-members.md)