﻿using System.Diagnostics;
                                                color-tagger  = "Akka.Persistence.TCK.Query.ColorFruitTagger, Akka.Persistence.TCK"
                                            }
                                            event-adapter-bindings = {
                                                "System.String" = color-tagger
                                            }