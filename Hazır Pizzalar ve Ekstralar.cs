using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacı_Sipariş_Ekranı
{
    public partial class Hazır_Pizzalar_ve_Ekstralar : Form
    {
        public Hazır_Pizzalar_ve_Ekstralar()
        {
            InitializeComponent();
        }

        private void bolMalzemosPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__1_;
            lblad.Text = "Bol Malzemos Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void extravaganzzaPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__2_;
            lblad.Text = "Extravaganzza Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void konyalımPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__3_;
            lblad.Text = "Konyalım Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void callypsoPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__4_;
            lblad.Text = "Callypso Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void karışıkPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__5_;
            lblad.Text = "Karışık Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void pastırmaSucukPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__6_;
            lblad.Text = "Pastırma-Sucuk Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void bolEtliPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__7_;
            lblad.Text = "Bol Etli Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void dopdoluExtraPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__8_;
            lblad.Text = "Dopdolu Extra Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void tavukluPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__9_;
            lblad.Text = "Tavuklu Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void üçPeynirliPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__10_;
            lblad.Text = "Üç Peynirli Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void vegiPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__11_;
            lblad.Text = "Vegi Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void sosyalPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__12_;
            lblad.Text = "Sosyal Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void domimixPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__13_;
            lblad.Text = "Domimix Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void margaritaPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__14_;
            lblad.Text = "Margarita Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void mangalSucukluPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__15_;
            lblad.Text = "Mangal Sucuklu Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void mantarseverPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__16_;
            lblad.Text = "Mantarsever Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void sucukseverPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__17_;
            lblad.Text = "Sucuksever Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void peperonniPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__18_;
            lblad.Text = "Peperonni Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void kantinPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__19_;
            lblad.Text = "Kantin Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void ocakbaşıPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizza__25_;
            lblad.Text = "Ocakbaşı Pizza";
            txtacıklama.Text = "Beko's Pizza Bol Malzemos zengin malzeme içeriği ile öne çıkar. Pizza denince akla gelen yumuşak hamur, dolgun peynir ve pizzanın olmazsa olmazları mantar, jambon, sosis, sucuk ve biber Beko's kalitesiyle bu pizzada buluşur! Toplantıların, arkadaş buluşmalarının, akşam yemeklerinin, keyifli sohbetlerin vazgeçilmezi haline gelen pratik ve doyurucu bol malzemeli pizzanız pratik bir şekilde evinize ulaşır. Birbiri ile uyumlu içeriklerin bir araya gelerek 20 yıllık Beko's tecrübesi ile hazırlanan Bol Malzemos Pizza'nın lezzet sırlarından en önemlisi malzemeleri birleştiren mozzarella peynirinin kalitesidir! Piliç ve hindi etlerinden özenle hazırlanan sucuk, sosis, pepperoni ve jambon ise mozzarellanın üzerine özenle yerleştirilir. Bol malzemeli pizzaseverlerin de kısa sürede ilgisini kendine çekmeyi başarır. Susam ve kekik ise baharat sevenlerin damak tadına hitap eder.";
        }

        private void margaritaPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__1_;
            lblad.Text = "Margarita Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void sucukluPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__2_;
            lblad.Text = "Sucuklu Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void karışıkPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__3_;
            lblad.Text = "Karışık Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void sebzeliPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__4_;
            lblad.Text = "Sebzeli Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void pastırmalıPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__5_;
            lblad.Text = "Pastırmalı Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void sosisliPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__6_;
            lblad.Text = "Sosisli Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void kavurmalıPizzettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pizzetta__7_;
            lblad.Text = "Kavurmalı Pizzetta";
            txtacıklama.Text = "Beko’s, alışılagelmiş yuvarlak pizzaların aksine dört köşeli şekli ve boyutuyla doyurucu bir öğün olarak geliştirilen Pizzetta’yı tüketicilerle buluşturuyor. Küçük büyük demeden herkesin severek yiyebileceği ve kolaylıkla ulaşabileceği Pizzetta, Beko’s Sofrası’nın en yeni üyesi olarak favori öğünler listesindeki yerini alıyor.";
        }

        private void whopperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.whopper;
            lblad.Text = "Whopper Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void kingBeefBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.king_beef_burger;
            lblad.Text = "King Beef Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void favBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fav_burger;
            lblad.Text = "Fav Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void köfteburgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kofteburger_1;
            lblad.Text = "Köfte Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void bKSteakhouseBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.bk_steakhouse_burger;
            lblad.Text = "Steakhouse Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void etliBarbeküBriocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.etli_barbeku_brioche;
            lblad.Text = "Etli Barbekü Brioche Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void tavukluBarbeküBriocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tavuklu_barbeku_brioche;
            lblad.Text = "Tavuklu Barbekü Brioche Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void bigKingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.big_king;
            lblad.Text = "Big King Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void cheeseBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cheeseburger;
            lblad.Text = "Cheese Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void chickenRoyaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.chicken_royale;
            lblad.Text = "Chicken Royale Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void kingChickenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.king_chicken_1;
            lblad.Text = "King Chicken Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void fishRoyaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fish_royale_1;
            lblad.Text = "Fish Royale Hamburger";
            txtacıklama.Text = "Tüm dünyada en çok sevilen yiyeceklerden biri olan Beko's Hamburger, iki yuvarlak ekmek arasına köfte, soğan, domates, turşu, peynir, marul, ketçap, mayonez ve hardal konularak sıcak servis edilen sandviç türüne denir. Hamburgerin en güzel yanı içerisine konulan malzemelerin bir sınırının olmamasıdır.";
        }

        private void tavukDürümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dürüm__2_;
            lblad.Text = "Tavuk Dürüm";
            txtacıklama.Text = "Beko's lezzetlerini bir kere deneyen asla vazgeçemiyor. Her acıktığınızda aklınıza düşecek bir lezzete sahip ürünlerimizi denediğinize asla pişman olmazsınız. Lezzetli olduğu kadar doyurucu olan Beko's lezzetlerimiz bol malzemesi ile enerjinize enerji katıyor. Beko's yedikten sonra doymamak mümkün değil.";            
        }

        private void etDürümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dürüm__5_;
            lblad.Text = "Et Dürüm";
            txtacıklama.Text = "Beko's lezzetlerini bir kere deneyen asla vazgeçemiyor. Her acıktığınızda aklınıza düşecek bir lezzete sahip ürünlerimizi denediğinize asla pişman olmazsınız. Lezzetli olduğu kadar doyurucu olan Beko's lezzetlerimiz bol malzemesi ile enerjinize enerji katıyor. Beko's yedikten sonra doymamak mümkün değil.";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dürüm__4_;
            lblad.Text = "Sucuk Dürüm";
            txtacıklama.Text = "Beko's lezzetlerini bir kere deneyen asla vazgeçemiyor. Her acıktığınızda aklınıza düşecek bir lezzete sahip ürünlerimizi denediğinize asla pişman olmazsınız. Lezzetli olduğu kadar doyurucu olan Beko's lezzetlerimiz bol malzemesi ile enerjinize enerji katıyor. Beko's yedikten sonra doymamak mümkün değil.";
        }

        private void çıtırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dürüm__3_;
            lblad.Text = "Çıtır Tavuk Dürüm";
            txtacıklama.Text = "Beko's lezzetlerini bir kere deneyen asla vazgeçemiyor. Her acıktığınızda aklınıza düşecek bir lezzete sahip ürünlerimizi denediğinize asla pişman olmazsınız. Lezzetli olduğu kadar doyurucu olan Beko's lezzetlerimiz bol malzemesi ile enerjinize enerji katıyor. Beko's yedikten sonra doymamak mümkün değil.";
        }

        private void adanaDürümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dürüm__6_;
            lblad.Text = "Adana Dürüm";
            txtacıklama.Text = "Beko's lezzetlerini bir kere deneyen asla vazgeçemiyor. Her acıktığınızda aklınıza düşecek bir lezzete sahip ürünlerimizi denediğinize asla pişman olmazsınız. Lezzetli olduğu kadar doyurucu olan Beko's lezzetlerimiz bol malzemesi ile enerjinize enerji katıyor. Beko's yedikten sonra doymamak mümkün değil.";
        }

        private void urfaDürümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dürüm__1_;
            lblad.Text = "Urfa Dürüm";
            txtacıklama.Text = "Beko's lezzetlerini bir kere deneyen asla vazgeçemiyor. Her acıktığınızda aklınıza düşecek bir lezzete sahip ürünlerimizi denediğinize asla pişman olmazsınız. Lezzetli olduğu kadar doyurucu olan Beko's lezzetlerimiz bol malzemesi ile enerjinize enerji katıyor. Beko's yedikten sonra doymamak mümkün değil.";
        }

        private void karışıkTostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.karısık;
            lblad.Text = "Karışık Tost";
            txtacıklama.Text = "Beko's tost, iki dilim ekmek arasına yerleştirilen bir veya birden fazla malzemenin ekmeklerle birlikte ısıtılması suretiyle yapılan sıcak sandviç. Genellikle kaşar, salam, sucuk, domates gibi malzemeler kullanılır.";
        }

        private void kaşarlıTostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kasarlı;
            lblad.Text = "Kaşarlı Tost";
            txtacıklama.Text = "Beko's tost, iki dilim ekmek arasına yerleştirilen bir veya birden fazla malzemenin ekmeklerle birlikte ısıtılması suretiyle yapılan sıcak sandviç. Genellikle kaşar, salam, sucuk, domates gibi malzemeler kullanılır.";
        }

        private void sucukluTostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sucuklu;
            lblad.Text = "Sucuklu Tost";
            txtacıklama.Text = "Beko's tost, iki dilim ekmek arasına yerleştirilen bir veya birden fazla malzemenin ekmeklerle birlikte ısıtılması suretiyle yapılan sıcak sandviç. Genellikle kaşar, salam, sucuk, domates gibi malzemeler kullanılır.";
        }

        private void kavurmalıTostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kavurmalı;
            lblad.Text = "Kavurmalı Tost";
            txtacıklama.Text = "Beko's tost, iki dilim ekmek arasına yerleştirilen bir veya birden fazla malzemenin ekmeklerle birlikte ısıtılması suretiyle yapılan sıcak sandviç. Genellikle kaşar, salam, sucuk, domates gibi malzemeler kullanılır.";
        }

        private void pastırmalıTostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pastırmalı;
            lblad.Text = "Pastırmalı Tost";
            txtacıklama.Text = "Beko's tost, iki dilim ekmek arasına yerleştirilen bir veya birden fazla malzemenin ekmeklerle birlikte ısıtılması suretiyle yapılan sıcak sandviç. Genellikle kaşar, salam, sucuk, domates gibi malzemeler kullanılır.";
        }

        private void yumurtalıTostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yumurtalı;
            lblad.Text = "Yumurtalı Tost";
            txtacıklama.Text = "Beko's tost, iki dilim ekmek arasına yerleştirilen bir veya birden fazla malzemenin ekmeklerle birlikte ısıtılması suretiyle yapılan sıcak sandviç. Genellikle kaşar, salam, sucuk, domates gibi malzemeler kullanılır.";
        }

        private void çikolatalıCookieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cikolatali_cookie;
            lblad.Text = "Çikolatalı Cookie";
            txtacıklama.Text = "Beko's Fastfood Evi şirketimize ait bizim aşcılarımıza özgü bir tatlıdır.";
        }

        private void çikolataParçacıklıCookieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cikolata_parcacikli_cookie;
            lblad.Text = "Çikolata Parçacıklı Cookie";
            txtacıklama.Text = "Beko's Fastfood Evi şirketimize ait bizim aşcılarımıza özgü bir tatlıdır.";
        }

        private void sufleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sufle;
            lblad.Text = "Suffle";
            txtacıklama.Text = "Beko's Fastfood Evi şirketimize ait bizim aşcılarımıza özgü bir tatlıdır.";
        }

        private void külahDondurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kulah_dondurma_1;
            lblad.Text = "Külah Dondurma";
            txtacıklama.Text = "Beko's Fastfood Evi şirketimize ait bizim aşcılarımıza özgü bir tatlıdır.";
        }

        private void Hazır_Pizzalar_ve_Ekstralar_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.blackcolor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(textBox1.Text);
            deger++;
            textBox1.Text = deger.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(textBox1.Text);
            deger--;
            textBox1.Text = deger.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favorilere Eklenildi");
            button1.Text = "Beğenilenlere Eklendi";
        }
    }
}
