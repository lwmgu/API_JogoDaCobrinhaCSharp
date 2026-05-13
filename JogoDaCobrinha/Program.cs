namespace JogoDaCobrinha
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// [STAThread] -> necessário para componentes gráficos
        /// do Windows Forms funcionarem corretamente
        [STAThread]
        static void Main()
        {
            // ativa o visual moderno do Windows
            // sem isso, os botões e componentes ficam com aparência antiga
            Application.EnableVisualStyles();

            // configuração para compatibilidade de renderização (renderizar -> mostrar na tela) de texto
            // false -> usa o mecanismo mais moderno
            Application.SetCompatibleTextRenderingDefault(false);

            // inicia a aplicação
            // abre a janela Form1
            // enquanto o form estiver aberto, o programa continuará executando
            Application.Run(new Form1());
        }
    }
}