   M S B A M L   `   `   `  ????S  OEmpresaRubroSanitarioWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EmpresaRubroSanitarioWPFEmpresaRubroSanitarioWPF  5   	   )    #EmpresaRubroSanitarioWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:EmpresaRubroSanitarioWPF     5   	   $	??400??5   	   $	??800??5	   	   
??????   ? WindowStyle$
  None=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ??  ?? CornerRadius$ 10??6   ???#FAF0CA._?5   
   ? -   5         ?Name$ GridPrincipal??5      
?????? .+?5      ? -   5        $??Header??5      $??35??5      $	??Top=?5      
?????? .+?5      ?? $ 	10,10,0,0??6   ???#2E2F5B5      ? 5       ? ColumnDefinitions 5      ?? 5      ?? 5      ?? 5      .+?5!      ?? $??EMPRESA RUBRO SANITARIO??6    $??1??5"       
???????$??20(?5$       $??Center=?5%       $??Center=?5&       ?? 5(      -   5         ??Name$ BtnMinimizar??5(      $??2??5)      
?????? 
?????? $??25??5,      $
??Left=?5-      $??	200,5,0,5q?5.      .??50      ?? $??/SCS/IMG/minimizar.png??6     ? Cursor$
 Hand??51       52      ?? 55      -   5        $ 	BtnCerrar??55      $??2??56      
?????? 
?????? $??25??59      $
??Left=?5:      $??	230,5,0,5q?5;      .??5=      ?? $??/SCS/IMG/cerrar.png??6    $
 Hand??5>       5?      5C      5D      ? 5G      -   5        $??	GridLogin??5G      .+?5H      ?? $C??=A D M I N I S T R A D O R   D E   R E Q U E R I M I E N T O S??6   $??Center=?5I      $	??Top=?5J      $??0, 100, 0, 0q?5K      $??25(?5L      $??SemiBold"?5M      ???#2E2F5B5N      ?? 5O      $??Usuario:??6   $
??Left=?5P      $??200,200,0,0q?5Q      $	??Top=?5R      $??20(?5S      $??SemiBold"?5T      ???#2E2F5B5U      ?? 5V      -   5        $??	tbUsuario??5W      $
??Left=?5V      $??30??5X      $??380,200,0,0q?5Y       ?? TextWrapping$
 Wrap=?5Z      $	??Top=?5[      $	??200??5\      ?? 5]      $??Contraseña:??6   $
??Left=?5^      $??200,240,0,0q?5_      $	??Top=?5`      $??20(?5a      $??SemiBold"?5b      ???#2E2F5B5c      G? 5d      -   5        $??tbContrasena??5e      $
??Left=?5d      $??30??5f      $??380,240,0,0q?5g      $	??Top=?5h      $	??200??5i      ?? 5j      -   5        $??btLogin??5l      $??Ingresar??5j      $??18(?5k      $??	95,0,0,60q?5m      $??Bottom=?5n      $??35??5o      $	??120??5p      6%   5r      5u      5v      5x      