using System;

namespace Anter.Win32.JL.DSSaveTools
{
	/// <summary>
	/// ClassCard ��ժҪ˵����
	/// </summary>
	public class CardClass
	{
		public int CardMode;		//��¼��ģʽ��0ΪNDS��1ΪGBA
		public string CardName;		//��¼������
		public string CardSName;	//��¼�����
		public string CardSaveType;	//��¼��֧�ֵĴ浵��С����λ�ַ�����0Ϊ��֧�֣�1Ϊ֧��
		public int SelectIndex;		//��¼����֧�ֵĴ浵��С��Ĭ�ϵ���Ŀ���
		public string CardExt;		//��¼����֧�ִ浵��׺
		public int CardIs;			//������¼����ʶ��1ΪM3,2ΪDSLink��0Ϊ������¼��
		public string CardInfo;		//��¼��˵��

		public CardClass(int CardModeI,string CardNameI,string CardSNameI,string CardSaveTypeI,int SelectIndexI,string CardExtI,int CardIsI,string CardInfoI)
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//

			CardMode = CardModeI;
			CardName = CardNameI;
			CardSName = CardSNameI;
			CardSaveType = CardSaveTypeI;
			SelectIndex = SelectIndexI;
			CardExt = CardExtI;
			CardIs = CardIsI;
			CardInfo = CardInfoI;
		}

		#region ��¼����Ϣ��ʼ��

		/*******************************************************************************************************
		public struct CardType			//��¼����Ϣ
		{
			public int CardMode;		//��¼��ģʽ��0ΪNDS��1ΪGBA
			public string CardName;		//��¼������
			public string CardSName;	//��¼�����
			public string CardSaveType;	//��¼��֧�ֵĴ浵��С����λ�ַ�����0Ϊ��֧�֣�1Ϊ֧��
			public int SelectIndex;		//��¼����֧�ֵĴ浵��С��Ĭ�ϵ���Ŀ���
			public string CardExt;		//��¼����֧�ִ浵��׺
			public int CardIs;			//������¼����ʶ��1ΪM3,2ΪDSLink��0Ϊ������¼��
			public string CardInfo;		//��¼��˵��

			public CardType(int CardModeI,string CardNameI,string CardSNameI,string CardSaveTypeI,int SelectIndexI,string CardExtI,int CardIsI,string CardInfoI)
			{
				CardMode = CardModeI;
				CardName = CardNameI;
				CardSName = CardSNameI;
				CardSaveType = CardSaveTypeI;
				SelectIndex = SelectIndexI;
				CardExt = CardExtI;
				CardIs = CardIsI;
				CardInfo = CardInfoI;
			}

		}

		private void SetCardType()		//����¼������֧��
		{
			/***********************************************************************************************************/
		/*                                                                                                         */
		/*  �ڱ��б�������Ŀʱ����Ҫ�޸ġ���ʼ����->��������ʼ����������������У�                                 */
		/*    static int NdsCards = 21+1;		//֧�ֵ�NDS��¼������������+1��ǰ������ֺ�DS��¼����������ͬ    */
		/*	  static int GbaCards = 7+1;		//֧�ֵ�GBA��¼������������+1��ǰ������ֺ�GBA��¼����������ͬ   */
		/*                                                                                                         */
		/**********************************************************************************************************



			//������NDS��¼���б�
			SetupCardType[0][0] = new CardType(0,"Acekard(+ & RPG)","AK","1110110",4,".nds.sav",0,"slot1�ӿڣ�ʹ������TF��������(RPGר��)�洢����׼�浵��ʽ����ѡ���С��");
			SetupCardType[0][1] = new CardType(0,"CycloDS Evolution","CE","0000010",1,".sav",0,"slot1�ӿڣ���׼512K�浵��ʽ��  ");
			SetupCardType[0][2] = new CardType(0,"DS FIRE LINK","DSFLK","0000100",1,".sav",0,"slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��(DSGBA OEM��Ʒ)");
			SetupCardType[0][3] = new CardType(0,"DSGBA","DSGBA","0000100",1,".sav",0,"slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��(DSGBA OEM��Ʒ)");
			SetupCardType[0][4] = new CardType(0,"DSLink","DSLK","0000010",1,".sav",2,"slot1�ӿڣ�ʹ�����ô洢оƬ���̶���520K���д浵��ʽ��");
			SetupCardType[0][5] = new CardType(0,"DSTT","DSTT","0000010",1,".sav",0,"slot1�ӿڣ�ʹ������TF���洢����׼512K�浵��ʽ��");
			SetupCardType[0][6] = new CardType(0,"EWIN2","EW2","0000110",2,".sav",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ���°汾���512K���ɰ汾���Ϊ256K��");
			SetupCardType[0][7] = new CardType(0,"EZ4","EZ4","0000100",1,".sav",0,"slot2�ӿڣ�ʹ�����ô洢оƬ��256K��׼�浵��ʽ��");
			SetupCardType[0][8] = new CardType(0,"EZ5","EZ5","1110110",4,".sav",0,"slot1�ӿڣ�ʹ������TF���洢����׼�浵��ʽ����ѡ���С��");
			SetupCardType[0][9] = new CardType(0,"G6 (Lite)","G6","0000110",1,".0",0,"slot2�ӿڣ�ʹ�����ô洢оƬ��256K��512K��׼�浵��ʽ��");
			SetupCardType[0][10] = new CardType(0,"G6 DS Real","G6DSR","0000010",1,".sav",0,"slot1�ӿڣ�ʹ�����ô洢оƬ����׼512K�浵��ʽ��");
			SetupCardType[0][11] = new CardType(0,"M3 (Lite)","M3","0000110",1,".dat",1,"slot2�ӿڣ�ʹ������SD��SD mini����257K��513K���д浵��ʽ��");
			SetupCardType[0][12] = new CardType(0,"M3 DS Real","M3DSR","0000010",1,".sav",0,"slot1�ӿڣ�ʹ������TF���洢����׼512K�浵��ʽ��");
			SetupCardType[0][13] = new CardType(0,"M3 DS Simply","M3DSS","0000010",1,".sav",0,"slot1�ӿڣ�ʹ������TF���洢����׼512K�浵��ʽ��");
			SetupCardType[0][14] = new CardType(0,"MK5","MK5","0000100",1,".sav",0,"slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��(DSGBA OEM��Ʒ)");
			SetupCardType[0][15] = new CardType(0,"N-CARD","NCARD","0000100",1,".sav",0,"slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��(DSGBA OEM��Ʒ)");
			SetupCardType[0][16] = new CardType(0,"R4","R4","0000010",1,".sav",0,"slot1�ӿڣ�ʹ������TF���洢����׼512K�浵��ʽ�� ");
			SetupCardType[0][17] = new CardType(0,"Super Card (Lite)","SC","0000100",1,".nds.sav",0,"slot2�ӿڣ�ʹ������SD��SD mini����256K��׼�浵��ʽ��");
			SetupCardType[0][18] = new CardType(0,"Super Card DS (ONE)","SCDS","1110110",4,".sav",0,"slot1�ӿڣ�ʹ������TF���洢����׼�浵��ʽ����ѡ���С��");
			SetupCardType[0][19] = new CardType(0,"SUNNY FLASH","SYFH","0000100",1,".sav",0,"slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��(DSGBA OEM��Ʒ)");
			SetupCardType[0][20] = new CardType(0,"(EMU) NO$GBA (Raw)","NO$GBA","0000010",1,".sav",0,"PC��DSģ����������ר�õ�����浵��ʽ��512K��׼�浵��ʽ���������ֻ��תΪRawģʽ��");
			SetupCardType[0][21] = new CardType(0,"Other (All Sizes)","OTHER","1111111",5,".sav",0,"δ֪�洢������֧�ֱ�׼�浵��ʽ��");


			//������GBA��¼���б�
			SetupCardType[1][0] = new CardType(1,"EZ 3IN1","3IN1","0001000",1,".sav",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ��");
			SetupCardType[1][1] = new CardType(1,"Elink (Lite)","Elink","1111000",3,".sav",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ��");
			SetupCardType[1][2] = new CardType(1,"EZ4","EZ4","0001000",1,".sav",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ��");
			SetupCardType[1][3] = new CardType(1,"G6 (Lite)","G6","0001000",1,".0",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ��");
			SetupCardType[1][4] = new CardType(1,"GBA Expansion Pack","GBAEP","0001000",1,".0",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ��");
			SetupCardType[1][5] = new CardType(1,"M3 (Lite)","M3","0001001",1,".dat",1,"slot2�ӿڣ�ʹ������SD��SD mini����129K����浵��ʽ��");
			SetupCardType[1][6] = new CardType(1,"Super Card (Lite)","SC","0001000",1,".nds.sav",0,"slot2�ӿڣ�ʹ������SD��SD mini������׼�浵��ʽ��");
			SetupCardType[1][7] = new CardType(1,"Other (All Sizes)","OTHER","1111111",4,".sav",0,"δ֪�洢������֧�ֱ�׼�浵��ʽ��");


			
			}
****************************************************************************************************************************/
		#endregion

	}
}
