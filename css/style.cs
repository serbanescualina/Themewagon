html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline; }

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block; }

body {
  line-height: 1; }

ol, ul {
  list-style: none; }

blockquote, q {
  quotes: none; }

blockquote:before, blockquote:after,
q:before, q:after {
  content: '';
  content: none; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

/*START PAGE*/
* {
  box-sizing: border-box; }

a {
  text-decoration: none;
  color: black; }

body {
  font-family: Arial, Helvetica, sans-serif; }

.header-mobile {
  display: flex;
  justify-content: space-between;
  margin: 20px; }
  .header-mobile a h1 {
    font-size: 30px;
    font-weight: 700; }
  .header-mobile a i {
    font-size: 25px;
    font-weight: 0;
    padding: 2px; }

.page-image {
  position: relative; }
  .page-image .image {
    min-height: 700px;
    overflow: hidden; }
    .page-image .image div img {
      width: 100%;
      min-height: 700px;
      min-width: 600px;
      position: relative;
      overflow: hidden; }

.image-text {
  max-width: 60%;
  vertical-align: middle;
  background: rgba(255, 255, 255, 0.85);
  padding: 40px;
  color: #828282;
  margin-left: auto;
  margin-right: auto;
  margin-top: -100%;
  position: relative; }
  .image-text h2 {
    margin: 20px 0;
    color: black;
    font-weight: 500;
    font-size: 25px; }
  .image-text .content {
    font-size: 12px;
    line-height: 2;
    margin-bottom: 20px; }
  .image-text .image-btn {
    padding: 10px 15px;
    font-size: 18px;
    border: 2px solid #d1c286;
    outline: none;
    box-shadow: none;
    background: transparent;
    color: rgba(209, 194, 134, 0.8);
    font-weight: 700;
    cursor: pointer; }
  .image-text .image-btn:hover {
    background: #d1c286;
    color: white; }

/*# sourceMappingURL=style.cs.map */
