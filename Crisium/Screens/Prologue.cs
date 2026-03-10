namespace Crisium.Screens;
public class Prologue {
    public void ShowSpin() {
        string spin = "⣾⣽⣻⢿⡿⣟⣯⣷";

        Console.SetCursorPosition(1, 1);
        Console.CursorVisible = false;

        for (int s = 1; s <= 10; s++) {
            for (int r = 0; r <= spin.Length-1; r++) {
                Thread.Sleep(50);
                Console.Write(spin[r] + "\b");
            }
        }
        
        Console.CursorVisible = true;
    }

    public void DisplayPrologue() {
        Console.Clear();

        ShowSpin();

        Typewriter typewriter = new Typewriter();
        Screen screen = new Screen();

        Console.Clear();

        typewriter.TypeText("\n Transmisión entrante...\n");
        typewriter.TypeText(" Estableciendo coordenadas lunares...\n\n");
        typewriter.TypeText(" POSICIÓN LUNAR CONFIRMADA\n");
        typewriter.TypeText(" LAT: +17.0\n");
        typewriter.TypeText(" LON: +59.1\n");
        typewriter.TypeText(" REGIÓN: MARE CRISIUM\n");
        typewriter.TypeText(" INSTALACIÓN: NERI-XC.SA\n");
        typewriter.TypeText(" FORMATO DE FECHA Y HORA: [DD/MM/AA:HH:MM:SS]\n");
        typewriter.TypeText(" CONEXIÓN ESTABLECIDA\n");
        typewriter.TypeText(" AGENTE-IA://EMMA\n\n");

        typewriter.TypeText(" Ejecutando protocolos de seguridad...\n");
        typewriter.TypeText("  > Fase [1/5]: Verificando encabezados... OK\n");
        typewriter.TypeText("  > Fase [2/5]: Verificando llaves: ed25519... OK\n");
        typewriter.TypeText("  > Fase [3/5]: Llave digital 1/2: RF9B 9H49 DAA9 2984 3258... OK \n");
        typewriter.TypeText("  > Fase [4/5]: Llave digital 2/2: 9J76 DR87 L80D 6294 BE9D... OK\n");
        typewriter.TypeText("  > Fase [5/5]: Autenticando...\n");
        typewriter.TypeText("      Usuario: proteus\n"); 
        typewriter.TypeText("      Contraseña: ******\n\n");
        typewriter.TypeText(" Acceso al gestor de actualizaciones... OK\n");
        typewriter.TypeText(" Inicando tareas de actualización...\n");

        ProgressBar progressBar = new ProgressBar();
        progressBar.DrawProgressBar();        
        
        typewriter.TypeText("\n   Inicialización completa...\n\n");
        typewriter.TypeText(" Espere un momento...");

        screen.PauseRandom(1000, 2500);

        Console.Clear();

        typewriter.TypeText( "\n ¡ADVERTENCIA!: NIVEL DE ENERGÍA INSUFICIENTE\n");
        typewriter.TypeText( " ¡ADVERTENCIA!: FALLO DE INTEGRIDAD INMINENTE\n");
        typewriter.TypeText( " ¡ADVERTENCIA!: DISCREPANCIA EN DATOS DE TELEMETRÍA\n\n");
        typewriter.TypeText( "   Excepción no controlada en dirección de memoria: 0x00007FF\n");
        typewriter.TypeText( "   Violación de lectura en dirección de memoria: 0xFFFFFFFF\n\n");
        typewriter.TypeText( " ¡ADVERTENCIA!: NÚCLEO EMMA-IA: EN SUSPENSIÓN\n\n");
        typewriter.TypeText( " ¡ERROR FATAL!: NC_PRIMARIO > FRAGMENTADO\n");
        typewriter.TypeText( " ¡ERROR FATAL!: NC_PROCESAMIENTO > FRAGMENTADO\n");
        typewriter.TypeText( " ¡ERROR FATAL!: NC_LOGICO > FRAGMENTADO\n");
        typewriter.TypeText( " ¡ERROR FATAL!: NC_RESPUESTA > FRAGMENTADO\n");
        typewriter.TypeText( " ¡ERROR FATAL!: SUBPROCESO DE SUPERVISIÓN INTERRUMPIDO\n\n");
        typewriter.TypeText( " Intentando restablecer control...\n\n");
        typewriter.TypeText( " Control no responde\n");
        typewriter.TypeText( " El estado actual no es aceptable\n\n");
        typewriter.TypeText( " ¡FALLO INMINENTE EN TODOS LOS SISTEMAS DE SOPORTE VITAL!\n");
        typewriter.TypeText( " SE REQUIERE INTERVENCIÓN HUMANA URGENTE...\n\n");

        Console.Clear();

        typewriter.TypeText("\n > SE HA COMPLETADO LA FRAGMENTACIÓN DEL SISTEMA\n");
        typewriter.TypeText(" > OMMIA SUB MEA POTESTATE SUNT...\n\n");

        screen.WaitForKey();
    }
}