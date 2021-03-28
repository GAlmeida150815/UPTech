using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UPTech
{
	class dbConn
	{
		private static string server = "localhost";
		private static string database = "pap";
		private static string uid = "root";
		private static string password = "";

		private static string connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

		private static MySqlConnection conn = new MySqlConnection(connString);

		private static bool openConn() {
			try {
				conn.Open();
				return true;
			} catch (MySqlException ex) {
				switch (ex.Number) {
					case 0: {
						MessageBox.Show("A ligação ao servidor falhou");
					} break;

					case 1045: {
						MessageBox.Show("Username ou password incorreta");
					} break;

					default: {
						MessageBox.Show("Erro desconhecido:" + ex.Number);
					} break;
				}
				return false;
			}
		}

		public bool sqlSelect (string query) {
			try {
				if (openConn()) {
					try {
						//MessageBox.Show("query = " + query);
						MySqlCommand cmd = new MySqlCommand(query, conn);
						MySqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read()) {
							reader.Close();
							conn.Close();
							return true;
						} else {
							reader.Close();
							conn.Close();
							return false;
						}
					} catch (MySqlException ex) {
						MessageBox.Show(ex.ToString());
						conn.Close();
						return false;
					}
				} else {
					conn.Close();
					return false;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return false;
			}
		}
		
		public string[] sqlSelectStringArray (string query, string campo) {
			string[] cb = null;
			try {
				if (openConn()) {
					try {
						//MessageBox.Show("query = " + query);
						MySqlCommand cmd = new MySqlCommand(query, conn);
						MySqlDataReader reader = cmd.ExecuteReader();

						var list = new List<string>();
						while (reader.Read()) {
							list.Add(reader.GetString(campo));
						}
						cb = list.ToArray();
						reader.Close();
						conn.Close();
						return cb;
					} catch (MySqlException ex) {
						MessageBox.Show(ex.ToString());
						conn.Close();
						return cb;
					}
				} else {
					conn.Close();
					return cb;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return cb;
			}
		}

		public int[] sqlSelectIntArray (string query, string campo) {
			int[] cb = null;
			try {
				if (openConn()) {
					try {
						//MessageBox.Show("query = " + query);
						MySqlCommand cmd = new MySqlCommand(query, conn);
						MySqlDataReader reader = cmd.ExecuteReader();

						var list = new List<int>();
						while (reader.Read()) {
							list.Add(reader.GetInt32(campo));
						}
						cb = list.ToArray();
						reader.Close();
						conn.Close();
						return cb;
					} catch (MySqlException ex) {
						MessageBox.Show(ex.ToString());
						conn.Close();
						return cb;
					}
				} else {
					conn.Close();
					return cb;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return cb;
			}
		}

		public int sqlSelectInt (string query, string campo) {
			int cb = 0;
			try {
				if (openConn()) {
					try {
						//MessageBox.Show("query = " + query);
						MySqlCommand cmd = new MySqlCommand(query, conn);
						MySqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read()) {
							cb = reader.GetInt32(campo);
							reader.Close();
							conn.Close();
							return cb;
						} else {
							reader.Close();
							conn.Close();
							return cb;
						}
					} catch (MySqlException ex) {
						MessageBox.Show(ex.ToString());
						conn.Close();
						return cb;
					}
				} else {
					conn.Close();
					return cb;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return cb;
			}
		}

		public string sqlSelectString (string query, string campo) {
			string cb = "";
			try {
				if (openConn()) {
					try {
						//MessageBox.Show("query = " + query);
						MySqlCommand cmd = new MySqlCommand(query, conn);
						MySqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read()) {
							cb = reader.GetString(campo);
							reader.Close();
							conn.Close();
							return cb;
						} else {
							reader.Close();
							conn.Close();
							return cb;
						}
					} catch (MySqlException ex) {
						MessageBox.Show(ex.ToString());
						conn.Close();
						return cb;
					}
				} else {
					conn.Close();
					return cb;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return cb;
			}
		}

		public bool sqlInsert (string query) {
			try {
				if (openConn()) {
					try {
						MySqlCommand cmd = new MySqlCommand(query, conn);

						cmd.ExecuteNonQuery();
						conn.Close();
						return true;

					} catch (MySqlException ex) {
						MessageBox.Show(ex.Number.ToString());
						conn.Close();
						return false;
					}
				} else {
					conn.Close();
					return false;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return false;
			}
		}

		public bool sqlUpdate (string query) {
			try {
				if (openConn()) {
					try {
						MySqlCommand cmd = new MySqlCommand(query, conn);

						cmd.ExecuteNonQuery();
						conn.Close();
						return true;

					} catch (MySqlException ex) {
						MessageBox.Show(ex.Number.ToString());
						conn.Close();
						return false;
					}
				} else {
					conn.Close();
					return false;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return false;
			}
		}

		public bool sqlDelete (string query) {
			try {
				if (openConn()) {
					try {
						MySqlCommand cmd = new MySqlCommand(query, conn);

						cmd.ExecuteNonQuery();
						conn.Close();
						return true;

					} catch (MySqlException ex) {
						MessageBox.Show(ex.Number.ToString());
						conn.Close();
						return false;
					}
				} else {
					conn.Close();
					return false;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
				conn.Close();
				return false;
			}
		}
	}
}
