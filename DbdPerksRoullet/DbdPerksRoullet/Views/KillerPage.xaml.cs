using DbdPerksRoullet.Enums;
using DbdPerksRoullet.Views;

namespace DbdPerksRoullet;

public partial class KillerPage : ContentPage {
    public KillerPage() {
        InitializeComponent();
    }

    private int count = 0;
    private string caminho01 = null;
    private string caminho02 = null;
    private string caminho03 = null;
    private string caminho04 = null;

    private void KillerPerk(object sender, EventArgs e) {

        NoPerks(2);

        var set = RandomPerks();
        perk1.Source = ImageSource.FromFile(set.Keys.ElementAt(0));  //programação funciona tipo bloquinhos kkk
        perk2.Source = ImageSource.FromFile(set.Keys.ElementAt(1));  //é tipo peçinhas de lego, se voce souber onde cada uma se encaixa
        perk3.Source = ImageSource.FromFile(set.Keys.ElementAt(2));  //e encaixar peçinha por peçinha
        perk4.Source = ImageSource.FromFile(set.Keys.ElementAt(3));  //voce pode montar um castelo.

        var texts = set.Values.ToList();
        Cut(texts, 27);
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

        var listK = new Dictionary<string, string> {
    { "iconperks_agitation.png", "Trapper: Agitação" },
    { "iconperks_alieninstinct.png", "Xenomorph: Instinto Alienígena" },
    { "iconperks_anursescalling.png", "Nurse: Chamado da Enfermeira" },
    { "iconperks_awakenedawarenesss.png", "Mastermind: Consciência Desperta" },
    { "iconperks_bamboozle.png", "Clown: Enganei Você!" },
    { "iconperks_batteriesincluded.png", "Unknown: Baterias Inclusas" },
    { "iconperks_bbqandchili.png", "Bubba: Churrasco com Chili" },
    { "iconperks_beastofprey.png", "Huntress: Fera de Caça" },
    { "iconperks_bittermurmur.png", "Geral: Murmúrio Amargo" },
    { "iconperks_bloodecho.png", "Oni: Eco de Sangue" },
    { "iconperks_bloodhound.png", "Wraith: Cão de Caça" },
    { "iconperks_bloodwarden.png", "Nightmare: Guardião Sanguinário" },
    { "iconperks_brutalstrength.png", "Trapper: Força Brutal" },
    { "iconperks_callofbrine.png", "Onryo: Chamado da Salmoura" },
    { "iconperks_corruptintervention.png", "Plague: Intervenção Corrompida" },
    { "iconperks_coulrophobia.png", "Clown: Coulrofobia" },
    { "iconperks_coupdegrace.png", "Twins: Coup de Grâce" },
    { "iconperks_cruelconfinement.png", "Artist: Confinamento Cruel" },
    { "iconperks_darkarrogance.png", "Dark Lord: Arrogância Sombria" },
    { "iconperks_darkdevotion.png", "Plague: Devoção Sombria" },
    { "iconperks_darknessrevelated.png", "Dredge: Escuridão Revelada" },
    { "iconperks_deadlock.png", "Cenobite: Deadlock" },
    { "iconperks_deadmanswitch.png", "Deathslinger: Interruptor do Homem Morto" },
    { "iconperks_deathbound.png", "Executioner: Vínculo Mortal" },
    { "iconperks_deerstalker.png", "Geral: Rastreador de Veados" },
    { "iconperks_devourhope.png", "Hag: Devorar Esperança" },
    { "iconperks_discordance.png", "Legion: Discordância" },
    { "iconperks_dissolution.png", "Dredge: Dissolução" },
    { "iconperks_distressing.png", "Geral: Perturbador" },
    { "iconperks_dominance.png", "Unknown: Dominância" },
    { "iconperks_dragonsgrip.png", "Blight: Garra do Dragão" },
    { "iconperks_dyinglight.png", "Myers: Perdendo a Esperança" },
    { "iconperks_enduring.png", "Hillbilly: Resistência" },
    { "iconperks_eruption.png", "Nemesis: Erupção" },
    { "iconperks_fireup.png", "Nightmare: Motivação" },
    { "iconperks_floodofrage.png", "Onryo: Inundação de Fúria" },
    { "iconperks_forcedhesitation.png", "Unknown: Hesitação Forçada" },
    { "iconperks_forcedpenance.png", "Executioner: Penitência Forçada" },
    { "iconperks_franklinsloss.png", "Bubba: A Morte de Franklin" },
    { "iconperks_furtivechase.png", "Ghost Face: Perseguição Furtiva" },
    { "iconperks_gameafoot.png", "Skull Merchant: Jogo em Andamento" },
    { "iconperks_gearhead.png", "Deathslinger: Cabeça de Engrenagem" },
    { "iconperks_generatorovercharge.png", "Doctor: Sobrecarga" },
    { "iconperks_geneticlimits.png", "Singularity: Limites Genéticos" },
    { "iconperks_hatred.png", "Spirit: Rancor" },
    { "iconperks_hauntedground.png", "Spirit: Terreno Assombrado" },
    { "iconperks_hexbloodfavor.png", "Blight: Favor de Sangue" },
    { "iconperks_hexcrowdcontrol.png", "Trickster: Controle de Multidão" },
    { "iconperks_hexfacethedarkness.png", "Knight: Encare a Escuridão" },
    { "iconperks_hexplaything.png", "Cenobite: Brinquedo Amaldiçoado" },
    { "iconperks_hexretribution.png", "Deathslinger: Retribuição" },
    { "iconperks_hexundying.png", "Blight: Imortalidade" },
    { "iconperks_hexwretchedfate.png", "Unknown: Destino Miserável" },
    { "iconperks_hoarder.png", "Twins: Acumulador" },
    { "iconperks_hubris.png", "Knight: Húbris" },
    { "iconperks_huntresslullaby.png", "Huntress: Canção de Ninar" },
    { "iconperks_hysteria.png", "Nemesis: Histeria" },
    { "iconperks_imallears.png", "Ghost Face: Sou Todo Ouvidos" },
    { "iconperks_infectiousfright.png", "Plague: Pavor Contagiante" },
    { "iconperks_insidious.png", "Geral: Insidioso" },
    { "iconperks_irongrasp.png", "Geral: Aperto de Ferro" },
    { "iconperks_ironmaiden.png", "Legion: Dama de Ferro" },
    { "iconperks_knockout.png", "Bubba: Nocaute" },
    { "iconperks_lethalpursuer.png", "Nemesis: Perseguidor Letal" },
    { "iconperks_leverage.png", "Unknown: Alavancagem" },
    { "iconperks_lightborn.png", "Hillbilly: Imune à Luz" },
    { "iconperks_madgrit.png", "Legion: Persistência Insana" },
    { "iconperks_makeyourchoice.png", "Pig: Faça Sua Escolha" },
    { "iconperks_mercilessstorm.png", "Onryo: Tempestade Implacável" },
    { "iconperks_mindbreaker.png", "Demogorgon: Invasor Mental" },
    { "iconperks_monitorandabuse.png", "Doctor: Monitore & Abuse" },
    { "iconperks_monstrousshrine.png", "Geral: Santuário Monstruoso" },
    { "iconperks_nemesis.png", "Nemesis: Nêmesis" },
    { "iconperks_nooneescapesdeath.png", "Geral: Ninguém Escapa da Morte" },
    { "iconperks_nowayout.png", "Trickster: Sem Saída" },
    { "iconperks_nowheretohide.png", "Knight: Sem Onde se Esconder" },
    { "iconperks_oppression.png", "Twins: Opressão" },
    { "iconperks_overwhelmingpresence.png", "Doctor: Presença Esmagadora" },
    { "iconperks_playwithyourfood.png", "Myers: Brinque com a Sua Comida" },
    { "iconperks_popgoestheweasel.png", "Clown: E Assim Gira o Carrosel" },
    { "iconperks_predator.png", "Wraith: Predador" },
    { "iconperks_rapidbrutality.png", "Xenomorph: Brutalidade Rápida" },
    { "iconperks_rememberme.png", "Nightmare: Lembre-se de Mim" },
    { "iconperks_ruin.png", "Hag: Arruinar" },
    { "iconperks_savethebestforlast.png", "Myers: Deixe o Melhor pro Final" },
    { "iconperks_scourgehookgiftofpain.png", "Artist: Presente da Dor" },
    { "iconperks_shadowborn.png", "Wraith: Nascido das Sombras" },
    { "iconperks_sloppybutcher.png", "Geral: Açougueiro Desleixado" },
    { "iconperks_spiesfromtheshadows.png", "Geral: Espiões das Sombras" },
    { "iconperks_spiritfury.png", "Spirit: Fúria Espiritual" },
    { "iconperks_starstruck.png", "Trickster: Estrela" },
    { "iconperks_stridor.png", "Nurse: Estridor" },
    { "iconperks_superioranatomy.png", "Mastermind: Anatomia Superior" },
    { "iconperks_surge.png", "Demogorgon: Pico de Tensão" },
    { "iconperks_surveillance.png", "Pig: Vigilância" },
    { "iconperks_hangmanstrick.png", "Pig: Truque do Carrasco" },
    { "iconperks_terminus.png", "Mastermind: Terminus" },
    { "iconperks_territorialimperative.png", "Hunter: Instinto Territorial" },
    { "iconperks_thatanophobia.png", "Nurse: Tanatofobia" },
    { "iconperks_thethirdseal.png", "Hag: O Terceiro Selo" },
    { "iconperks_thrillingtremors.png", "Ghost Face: Tremores de Terror" },
    { "iconperks_thwack.png", "Skull Merchant: Thwack!" },
    { "iconperks_tinkerer.png", "Hillbilly: Engenhoqueiro" },
    { "iconperks_trailoftorment.png", "Executioner: Rastro de Tormento" },
    { "iconperks_ultimateweapon.png", "Xenomorph: Arma Suprema" },
    { "iconperks_unbound.png", "Singularity: Desacorrentado" },
    { "iconperks_undone.png", "Unknown: Desfeito" },
    { "iconperks_unforeseen.png", "Unknown: Imprevisível" },
    { "iconperks_unnervingpresence.png", "Trapper: Presença Desconcentrante" },
    { "iconperks_unrelenting.png", "Geral: Implacável" },
    { "iconperks_whispers.png", "Geral: Sussurros" },
    { "iconperks_zanshintactics.png", "Oni: Táticas Zanshin" }
};
        var perks = new Dictionary<string, string>();
        Random random = new Random();

        while (perks.Count < 4) {

            var randomPerk1 = listK.ElementAt(random.Next(listK.Count));
            var randomPerk2 = listK.ElementAt(random.Next(listK.Count));
            var randomPerk3 = listK.ElementAt(random.Next(listK.Count));
            var randomPerk4 = listK.ElementAt(random.Next(listK.Count));

            NoPerks(4);
            perks[randomPerk1.Key] = randomPerk1.Value;
            perks[randomPerk2.Key] = randomPerk2.Value;
            perks[randomPerk3.Key] = randomPerk3.Value;
            perks[randomPerk4.Key] = randomPerk4.Value;

            perks = perks.OrderBy(p => p.Value.Length).ToDictionary();
        }


        return perks;
    }

    private void KillerPerksReset(object sender, TappedEventArgs e) {

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
