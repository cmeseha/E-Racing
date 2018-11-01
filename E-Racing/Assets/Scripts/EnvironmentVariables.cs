using System;
// ﻿using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

namespace EnvironmentVariablesNS {
	public class EnvironmentVariables {

		public EnvironmentVariables() {
			Environment.SetEnvironmentVariable("username", "markmoussa");
			Environment.SetEnvironmentVariable("password", "5cx9GEtQg78gHUy");
		}
	}
}
