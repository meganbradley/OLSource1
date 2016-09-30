---
title: "F# Interactive Options"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "readline F# interactive command line option"
  - "quiet F# interactive command line option"
  - "exec F# interactive command line option"
  - "use F# interactive command line option"
  - "load F# interactive command line option"
  - "F# interactive command line options"
  - "gui F# interactive command line option"
ms.assetid: 55bf9504-1402-4707-a88d-34f4f8904365
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F# Interactive Options
This topic describes the command-line options supported by F# Interactive, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. F# Interactive accepts many of the same command line options as the F# compiler, but also accepts some additional options.  
  
## Using F# Interactive for Scripting  
 F# Interactive, fsi.exe, can be launched interactively, or it can be launched from the command line to run a script. The command line syntax is  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>] ]  
  
 The file extension for F# script files is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Table of F# Interactive Options  
 The following table summarizes the options supported by F# Interactive. You can set these options on the command-line or through the Visual Studio IDE. To set these options in the Visual Studio IDE, open the **Tools** menu, select **Options...**, then expand the **F# Tools** node and select **F# Interactive**.  
  
 Where lists appear in F# Interactive option arguments, list elements are separated by semicolons (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
|Option|Description|  
|------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Used to instruct F# Interactive to treat remaining arguments as command line arguments to the F# program or script, which you can access in code by using the list <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>]|Same as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>]|Enable or disable cross-module optimizations.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>]\<br />\<br /> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>]\<br />\<br /> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>]\<br />\<br /> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>]|Same as the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Instructs F# interactive to exit after loading the files or running the script file given on the command line.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>]|Enables or disables the Windows Forms event loop. The default is enabled.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Used to display the command line syntax and a brief description of each option.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Compiles the given source code at startup and loads the compiled F# constructs into the session. If the target source contains scripting directives such as <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, then you must use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md)|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>]|Same as the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Suppress F# Interactive's output to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> stream.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Specifies that extra debugging information should be emitted for expressions that are derived from F# quotation literals and reflected definitions. The debug information is added to the custom attributes of an F# expression tree node. See [Code Quotations](../vs140/code-quotations--fsharp-.md) and [Expr.CustomAttributes](../vs140/expr.customattributes-property--fsharp-.md).|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>]|Enable or disable tab completion in interactive mode.|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>]|Enable or disable the use of the tail IL instruction, which causes the stack frame to be reused for tail recursive functions. This option is enabled by default.|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Tells the interpreter to use the given file on startup as initial input.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Same as the fsc.exe compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>]|Same as the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>]:<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Same as the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> compiler option. For more information, see [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md).|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Compiler Options (F#)](../vs140/compiler-options--fsharp-.md)|Describes command line options available for the F# compiler, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.|