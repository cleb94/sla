using DbdPerksRoullet.Enums;
using DbdPerksRoullet.Views;

namespace DbdPerksRoullet;

public partial class SuvivorPage : ContentPage {
    public SuvivorPage() {
        InitializeComponent();
    }

    private int count = 0;
    private string caminho01 = null;
    private string caminho02 = null;
    private string caminho03 = null;
    private string caminho04 = null;

    private void SuvivorPerk(object sender, EventArgs e) {

        NoPerks(2);

        var set = RandomPerks();
        perk1.Source = ImageSource.FromFile(set.Keys.ElementAt(0));  //programação funciona tipo bloquinhos kkk
        perk2.Source = ImageSource.FromFile(set.Keys.ElementAt(1));  //é tipo peçinhas de lego, se voce souber onde cada uma se encaixa
        perk3.Source = ImageSource.FromFile(set.Keys.ElementAt(2));  //e encaixar peçinha por peçinha
        perk4.Source = ImageSource.FromFile(set.Keys.ElementAt(3));  //voce pode montar um castelo.

        var texts = set.Values.ToList();
        Cut(texts, 27);  // o n é o tamanho de caracteres que a tela aguenta.
        text01.Text = texts[0];
        text02.Text = texts[1];
        text03.Text = texts[2];
        text04.Text = texts[3];

        caminho01 = set.Keys.ElementAt(0);  //nunca programe enquanto estiver exausto
        caminho02 = set.Keys.ElementAt(1);  //eu coloquei como value ao invés de key e fiquei 30min procurando erro onde nao tinha
        caminho03 = set.Keys.ElementAt(2);  //e o erro estava aqui.
        caminho04 = set.Keys.ElementAt(3);

        if (caminho01 == null) { var tap = new TapGestureRecognizer(); tap.Tapped -= null; }
        else { var tap = new TapGestureRecognizer(); tap.Tapped += TapGestureRecognizer_Tapped; }  //isso aqui eu criei para o botao do easter egg so funcionar quando as perks forem roletadas.
    }

    private Dictionary<string, string> RandomPerks() {

        var listS = new Dictionary<string, string>
{
    { "iconperks_aceinthehole.png", "Ace: Ás na Manga" },
    { "iconperks_adrenaline.png", "Meg: Adrenalina" },
    { "iconperks_aftercare.png", "Jeff: Cuidados" },
    { "iconperks_alert.png", "Feng Min: Em Alerta" },
    { "iconperks_anymeansnecessary.png", "Yui Kimura: Custe o que Custar" },
    { "iconperks_appraisal.png", "Elodie: Avaliação" },
    { "iconperks_autodidact.png", "Adam: Autodidata" },
    { "iconperks_babysitter.png", "Steve: Babá" },
    { "iconperks_backgroundplayer.png", "Renato: Jogador Tático" },
    { "iconperks_balancedlanding.png", "Nea: Queda Equilibrada" },
    { "iconperks_bardicinspiration.png", "Aestri Yazar: Inspiração de Bardo" },
    { "iconperks_betterthannew.png", "Rebecca: Novinhos em Folha" },
    { "iconperks_bettertogether.png", "Nancy: Melhor Juntos" },
    { "iconperks_bitethebullet.png", "Leon: Matar no Peito" },
    { "iconperks_blastmine.png", "Jill: Mina Explosiva" },
    { "iconperks_bloodpact.png", "Cheryl: Pacto de Sangue" },
    { "iconperks_bloodrush.png", "Renato: Disparada Sangrenta" },
    { "iconperks_boilover.png", "Kate: Superação" },
    { "iconperks_bond.png", "Dwight: Vinculo" },
    { "iconperks_booncircleofhealing.png", "Mikaela: Círculo Curativo" },
    { "iconperks_boonshadowstep.png", "Mikaela: Passo Sombrio" },
    { "iconperks_borrowedtime.png", "Bill: Tempo Precioso" },
    { "iconperks_botanyknowledge.png", "Claudette: Conhecimento Botânico" },
    { "iconperks_breakdown.png", "Jeff: Quebrar" },
    { "iconperks_breakout.png", "Yui Kimura: Fuga" },
    { "iconperks_buckleup.png", "Ash: Apertando os cintos" },
    { "iconperks_builttolast.png", "Felix: Construído para Durar" },
    { "iconperks_calmspirit.png", "Jake: Espírito Calmo" },
    { "iconperks_camaraderie.png", "Steve: Camaradagem" },
    { "iconperks_chemicaltrap.png", "Ellen: Armadilha Química" },
    { "iconperks_clairvoyance.png", "Mikaela: Clarividência" },
    { "iconperks_counterforce.png", "Jill: Contra-força" },
    { "iconperks_cutloose.png", "Thalita: Sem Restrições" },
    { "iconperks_teamworkpoweroftwo.png", "Thalita: Trabalho em Equipe: Poder de Dois" },
    { "iconperks_dancewithme.png", "Kate: Dance Comigo" },
    { "iconperks_darksense.png", "Geral: Sentido Sombrio" },
    { "iconperks_darktheory.png", "Yoichi: Teoria Sombria" },
    { "iconperks_deadhard.png", "David: Duro na Queda" },
    { "iconperks_deception.png", "Elodie: Enganação" },
    { "iconperks_decisivestrike.png", "Laurie: Ataque Decisivo" },
    { "iconperks_dejavu.png", "Geral: Déjà Vu" },
    { "iconperks_deliverance.png", "Adam: Libertação" },
    { "iconperks_desperatemeasures.png", "Felix: Medidas Desesperadas" },
    { "iconperks_detectiveshunch.png", "Tapp: Intuição de Detetive" },
    { "iconperks_distortion.png", "Jeff: Distorção" },
    { "iconperks_diversion.png", "Adam: Distração" },
    { "iconperks_dramaturgy.png", "Nicolas Cage: Dramaturgia" },
    { "iconperks_empathicconnection.png", "Yoichi: Ligação Empática" },
    { "iconperks_empathy.png", "Claudette: Empatia" },
    { "iconperks_eyesofbelmont.png", "Trevor: Olhos de Belmont" },
    { "iconperks_exultation.png", "Trevor: Exultação" },
    { "iconperks_momentofglory.png", "Trevor: Momento de Glória" },
    { "iconperks_fasttrack.png", "Yun-Jin: Fama Acelerada" },
    { "iconperks_fixated.png", "Nancy: Ideia Fixa" },
    { "iconperks_flashbang.png", "Leon: Granada de Luz" },
    { "iconperks_flipflop.png", "Ash: Bate e Volta" },
    { "iconperks_fogwise.png", "Vittorio: Sabedoria da Névoa" },
    { "iconperks_forthepeople.png", "Zarina: Pelo Povo" },
    { "iconperks_friendlycompetition.png", "Thalita: Competição Amigável" },
    { "iconperks_headon.png", "Jane: De Cabeça" },
    { "iconperks_hope.png", "Geral: Esperança" },
    { "iconperks_hyperfocus.png", "Rebecca: Hiperfoco" },
    { "iconperks_innerfocus.png", "Haddie: Foco Interno" },
    { "iconperks_innerstrength.png", "Nancy: Força Interior" },
    { "iconperks_ironwill.png", "Jake: Vontade de Ferro" },
    { "iconperks_kindred.png", "Geral: Afinidade" },
    { "iconperks_leader.png", "Dwight: Líder" },
    { "iconperks_leftbehind.png", "Bill: Deixado para Trás" },
    { "iconperks_lightfooted.png", "Ellen: Pés Leves" },
    { "iconperks_lightweight.png", "Geral: Leve" },
    { "iconperks_lithe.png", "Feng Min: Agilidade" },
    { "iconperks_lowprofile.png", "Ada: Discrição" },
    { "iconperks_luckybreak.png", "Yui Kimura: Golpe de Sorte" },
    { "iconperks_luckystar.png", "Ellen: Estrela da Sorte" },
    { "iconperks_madeforthis.png", "Gabriel: Feito para Isso" },
    { "iconperks_mettleofman.png", "Ash: Fervor Humano" },
    { "iconperks_mirroredillusion.png", "Aestri Yazar: Ilusão Espelhada" },
    { "iconperks_stillsight.png", "Aestri Yazar: Visão Estática" },
    { "iconperks_nooneleftbehind.png", "Geral: Ninguém Fica para Trás" },
    { "iconperks_objectofobsession.png", "Laurie: Objeto de Obsessão" },
    { "iconperks_offtherecord.png", "Zarina: Extraoficialmente" },
    { "iconperks_openhanded.png", "Ace: Mão Aberta" },
    { "iconperks_overzealous.png", "Haddie: Zeloso ao Extremo" },
    { "iconperks_parentalguidance.png", "Yoichi: Orientação Paterna" },
    { "iconperks_pharmacy.png", "Quentin: Farmácia" },
    { "iconperks_plottwist.png", "Nicolas Cage: Reviravolta" },
    { "iconperks_plunderersinstinct.png", "Geral: Instinto de Saqueador" },
    { "iconperks_poised.png", "Jane: Firmeza" },
    { "iconperks_finesse.png", "Lara Croft: Finesse" },
    { "iconperks_specialist.png", "Lara Croft: Especialista" },
    { "iconperks_hardened.png", "Lara Croft: Enrijecido" },
    { "iconperks_potentialenergy.png", "Vittorio: Energia Potencial" },
    { "iconperks_powerstruggle.png", "Elodie: Luta de Poder" },
    { "iconperks_premonition.png", "Geral: Premonição" },
    { "iconperks_provethyself.png", "Dwight: Prove-se" },
    { "iconperks_quickandquiet.png", "Meg: Rápida e Silenciosa" },
    { "iconperks_reactivehealing.png", "Ada: Cura Reativa" },
    { "iconperks_reassurance.png", "Rebecca: Reconforto" },
    { "iconperks_redherring.png", "Zarina: Alarme Falso" },
    { "iconperks_repressedalliance.png", "Cheryl: Aliança Reprimida" },
    { "iconperks_residualmanifest.png", "Haddie: Manifesto Residual" },
    { "iconperks_resilience.png", "Geral: Resiliência" },
    { "iconperks_resurgence.png", "Jill: Ressurgimento" },
    { "iconperks_rookiespirit.png", "Leon: Espírito de Recruta" },
    { "iconperks_saboteur.png", "Jake: Sabotador" },
    { "iconperks_scavenger.png", "Gabriel: Sucateiro" },
    { "iconperks_scenepartner.png", "Nicolas Cage: Parceiro de Cena" },
    { "iconperks_secondwind.png", "Steve: Segundo Fôlego" },
    { "iconperks_selfcare.png", "Claudette: Autocura" },
    { "iconperks_situationalawareness.png", "Dwight: Lider" },
    { "iconperks_slipperymeat.png", "Geral: Escorregadio" },
    { "iconperks_smallgame.png", "Geral: Caça Pequena" },
    { "iconperks_smashhit.png", "Yun-Jin: Hit de Sucesso" },
    { "iconperks_solesurvivor.png", "Laurie: Sobrevivente Único" },
    { "iconperks_solidarity.png", "Jane: Solidariedade" },
    { "iconperks_soulguard.png", "Cheryl: Proteção de Alma" },
    { "iconperks_spinechill.png", "Geral: Arrepio na Espinha" },
    { "iconperks_sprintburst.png", "Meg: Arrancada Explosiva" },
    { "iconperks_stakeout.png", "Tapp: Tocaia" },
    { "iconperks_streetwise.png", "Nea: Conhecimento Urbano" },
    { "iconperks_teamworkcollectivestealth.png", "Renato: Furtividade Coletiva" },
    { "iconperks_technician.png", "Feng Min: Técnico" },
    { "iconperks_tenacity.png", "Tapp: Tenacidade" },
    { "iconperks_thisisnothappening.png", "Geral: Isso Não Está Acontecendo" },
    { "iconperks_troubleshooter.png", "Yun-Jin: Solucionador de Problemas" },
    { "iconperks_unbreakable.png", "Bill: Inquebrável" },
    { "iconperks_uptheante.png", "Ace: Aumentar as Apostas" },
    { "iconperks_urbanevasion.png", "Nea: Evasão Urbana" },
    { "iconperks_vigil.png", "Quentin: Vigília" },
    { "iconperks_visionary.png", "Felix: Visionário" },
    { "iconperks_vittoriosgambit.png", "Vittorio: Gambito Rapido" },
    { "iconperks_wakeup.png", "Quentin: Acorde!" },
    { "iconperks_wellmakeit.png", "Geral: Vamos Conseguir" },
    { "iconperks_weregonnaliveforever.png", "David King: Vamos Viver para Sempre" },
    { "iconperks_windowsofopportunity.png", "Kate: Janelas de Oportunidades" },
    { "iconperks_wiretap.png", "Ada: Escuta" },
    { "iconsperks_championoflight.png", "Alan Wake: Campeão da Luz" },
    { "iconsperks_deadline.png", "Alan Wake: Prazo Final" },
    { "iconsperks_illumination.png", "Alan Wake: Iluminação" },
    { "iconsperks_invocationweavingspiders.png", "Sable: Aranhas Tecelãs" },
    { "iconsperks_strengthinshadows.png", "Sable: Força nas Sombras" },
    { "iconsperks_wicked.png", "Sable: Perversidade" },
    { "t_iconperks_boonexponential.png", "Jonah: Bênção: Exponencial" },
    { "t_iconperks_correctiveaction.png", "Jonah: Ação Corretiva" },
    { "t_iconperks_overcome.png", "Jonah: Superar" }
};
        var perks = new Dictionary<string, string>();
        Random random = new Random();

        while (perks.Count < 4) {

            var randomPerk1 = listS.ElementAt(random.Next(listS.Count));
            var randomPerk2 = listS.ElementAt(random.Next(listS.Count));
            var randomPerk3 = listS.ElementAt(random.Next(listS.Count));
            var randomPerk4 = listS.ElementAt(random.Next(listS.Count));

            NoPerks(4);
            perks[randomPerk1.Key] = randomPerk1.Value;
            perks[randomPerk2.Key] = randomPerk2.Value;
            perks[randomPerk3.Key] = randomPerk3.Value;
            perks[randomPerk4.Key] = randomPerk4.Value;
        }

        perks = perks.OrderBy(p => p.Value.Length).ToDictionary();
        return perks;
    }

    private void SuvivorPerksReset(object sender, TappedEventArgs e) {

        count += 1;
        if (count == 2) { NoPerks(1); NoPerks(3); count = 0; }

    }

    private void NoPerks(int value) {

        if (value == 1) {  //desaparecem
            noPerks.IsVisible = true;
            perk1.IsVisible = false;
            perk2.IsVisible = false;
            perk3.IsVisible = false;
            perk4.IsVisible = false;

            ButtonXD.Margin = new Thickness(0, 0);
        }
        else if (value == 2) {  //aparecem
            noPerks.IsVisible = false;
            perk1.IsVisible = true;
            perk2.IsVisible = true;
            perk3.IsVisible = true;
            perk4.IsVisible = true;

            ButtonXD.Margin = new Thickness(0, -10);
        }
        else if (value == 3) {
            text01.IsVisible = false;
            text02.IsVisible = false;
            text03.IsVisible = false;
            text04.IsVisible = false;
        }

        else if (value == 4) {
            text01.IsVisible = true;
            text02.IsVisible = true;
            text03.IsVisible = true;
            text04.IsVisible = true;
        }

    }

    private void Cut(List<string> texts, int n) {  //isso aqui é para cortar o string para caber na tela, quando eu aprender a configurar por tamanho de tela essa função vai ser muito util.

        for (int i = 0; i < texts.Count; i++) {
            if (texts[i].Length > n) {
                texts[i] = texts[i].Substring(0, n);
                texts[i] += "...";
            }
        }

    }
    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e) {

        var en = new PerksEnum();

        var Perks = new List<string>() { caminho01, caminho02, caminho03, caminho04 };
        bool xd = en.VazioRoxo(Perks);
        if (xd == true) {

            count += 1;

            if (count == 10) {
                count = 0;
                Navigation.PushAsync(new XD());

                await Task.Delay(1500); //stek2: quando é com telas o thread.sleep deixa ela congelada para sempre, entao no lugar use isso.
                await Navigation.PopAsync();  //pro await funcionar voce tem que colocar a assinatura antes do tipo da função. EX no caso esse é Async.
            }
        }

        else { count = 0; }

    }

}
