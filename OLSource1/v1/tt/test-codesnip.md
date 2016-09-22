---
title: "test codesnip"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3772edaf-ddab-4075-85b9-480b9ad64935
caps.latest.revision: 2
---
# test codesnip
## Welcome to CAPS Markdown Editor!

terryjin

[!code[howto](../testCodeSnippet/codesnippet/VisualBasic/test-codesnip_1.vb)]


[!code[adomd.netserver](../testCodeSnippet/codesnippet/CSharp/test-codesnip_2.cs)]


[!INCLUDE[applies_md](../testCodeSnippet/includes/applies_md.md)]

![5ff17e34-b578-4873-9d33-79500940d0bc](../testCodeSnippet/media/5ff17e34-b578-4873-9d33-79500940d0bc.gif)

```C#
  public static Set FilterSet(Set set, String filterExpression)
        {
            Expression expr = new Expression(filterExpression);

            SetBuilder resultSetBuilder = new SetBuilder();

            foreach (Tuple tuple in set)
            {
                if ((bool)(expr.Calculate(tuple)))
                {
                    resultSetBuilder.Add(tuple);
                }
            }

            return resultSetBuilder.ToSet();
        }
```

```vb
        Try
            ' Do something that may cause an exception.
            Throw New ApplicationException("An error has occured.")
        Catch ex As ApplicationException
            Dim str As String = "The action failed."
            Dim exTop As ApplicationException = New ApplicationException(str, ex)
            exTop.Source = Me.Text

            ' Show a message box if the global variable is true.
            If alwaysShow Then
                Dim box As ExceptionMessageBox = New ExceptionMessageBox(exTop)
                box.ShowCheckBox = True
                box.IsCheckBoxChecked = True
                box.CheckBoxText = "Always show this message"
                box.Show(Me)

                ' Set the global variable.
                alwaysShow = box.IsCheckBoxChecked
            End If
        End Try
```