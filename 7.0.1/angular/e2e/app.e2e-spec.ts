import { NhatKyDienTuTemplatePage } from './app.po';

describe('NhatKyDienTu App', function() {
  let page: NhatKyDienTuTemplatePage;

  beforeEach(() => {
    page = new NhatKyDienTuTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
